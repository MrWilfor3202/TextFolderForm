using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFolderForm.Model.Handlers.Abstract.Folders;
using TextFolderForm.Model.Logger.Abstract;
using TextFolderForm.Model.Logger.Implementations;

namespace TextFolderForm.Model.Handlers.Implementations.Folders
{
    public class SelecterFolder : IFoldersHandler
    {
        private ILogger _logger; 

        public SelecterFolder(ILogger logger)
        {
            _logger = logger;
        }

        public string HandleFolders(string path)
        {

            if (path == "" || path == " ")
                return "Выберите папку!";

            var directory = new DirectoryInfo(path);
            var files = directory.GetFiles();
            bool allFilesSorted = true;

            foreach (var file in files) 
            {
                var extensionDirectory = new DirectoryInfo(Path.Combine(path, file.Extension));
                var fullDirectory = Path.Combine(path, file.Extension, file.Name);
                
                try
                {
                    if(!extensionDirectory.Exists)
                        extensionDirectory.Create();


                    File.Move(file.FullName, fullDirectory, true);
                }
                catch(Exception e) 
                {
                    _logger.Log(e.Message);
                    _logger.Log(e.StackTrace);


                    allFilesSorted = false; 
                }
            }
            if (allFilesSorted)
                return "Файлы отсортированы!";
            else
                return "Не все файлы отсортированы! Смотрите в логи!";
        }
    }
}
