using TextFolderForm.Model.Handlers.Abstract.Text;

namespace TextFolderForm.Model.Handlers.Implementations.Text
{
    public class FileWriter : ITextHandler
    {
        public string HandleText(string text)
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var filePath = Path.Combine(desktopPath, "TextFileForm", "text.txt");

            var fileStream = File.Create(filePath);

            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.Write(text);
            }

            return filePath;
        }
    }
}
