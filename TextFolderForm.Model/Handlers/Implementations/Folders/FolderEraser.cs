using System.IO;
using TextFolderForm.Model.Handlers.Abstract.Folders;

namespace TextFolderForm.Model.Handlers.Implementations.Folders
{
    public class FolderEraser : IFoldersHandler
    {
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
                return "Не все папки и файлы очищены. Информация в консоли!";
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
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Data);
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
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(e.Data);
                }
            }

        }
    }
}
