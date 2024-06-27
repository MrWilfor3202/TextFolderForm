using System.IO;
using TextFolderForm.Model.Handlers.Abstract.Folders;
using TextFolderForm.Model.Logger.Abstract;
using TextFolderForm.Model.Logger.Implementations;

namespace TextFolderForm.Model.Handlers.Implementations.Folders
{
    public class FolderEraser : IFoldersHandler
    {
        private ILogger _logger;

        public FolderEraser(ILogger logger)
        {
            _logger = logger;
        }

        public string HandleFolders(string path)
        {
            if (path == "")
                return "Выберите папку";


            bool allFilesErased = true;

            var directory = new DirectoryInfo(path);
            
            foreach (var folder in directory.GetDirectories())
                DeleteDirectory(folder.FullName, ref allFilesErased);

            DeleteFilesInDirectory(path, ref allFilesErased);

            if (allFilesErased)
                return "Все папки очищены";
            else
                return "Не все папки и файлы очищены. Информация в логе!";
        }

        private void DeleteDirectory(string path, ref bool dirErased) 
        {
            var directory = new DirectoryInfo(path);

            DeleteFilesInDirectory(path, ref dirErased);

            try
            {
                directory.Delete();
            }
            catch(Exception e)
            {
                _logger.Log(e.Message);
                _logger.Log(e.StackTrace);
                dirErased = false;
            }
        }

        private void DeleteFilesInDirectory(string path, ref bool allFilesInDirErased)
        {
            var directory = new DirectoryInfo(path);

            foreach (var file in directory.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch(Exception e)
                {
                    allFilesInDirErased = false;
                    _logger.Log(e.Message);
                    _logger.Log(e.StackTrace);
                }
            }

        }
    }
}
