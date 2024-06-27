using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFolderForm.Model.Logger.Abstract;

namespace TextFolderForm.Model.Logger.Implementations
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            var projectDirectory = Environment.CurrentDirectory;

            var directoryInfo = new DirectoryInfo(Path.Combine(projectDirectory, "Logs"));

            if (!directoryInfo.Exists)
                directoryInfo.Create();

            var filePath = Path.Combine(directoryInfo.FullName, "text.txt");

            File.AppendAllText(filePath, "\n" + message + "\n");
        }
    }
}
