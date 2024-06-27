using TextFolderForm.Model.Handlers.Abstract.Text;
using TextFolderForm.Model.Handlers.Utils;

namespace TextFolderForm.Model.Handlers.Implementations.Text
{
    public class AlphabetWordsSorter : ITextHandler
    {
        public string HandleText(string text)
        {
            var result = text.Split(ConstantStorage.Separators, StringSplitOptions.RemoveEmptyEntries)
               .Select(text => text + " ")
               .OrderBy(word => word)
               .SelectMany(word => word)
               .ToArray();

            if (result.Length <= 0 ) 
            {
                return "";
            }

            var str = new string(result);
            return str.Remove(str.Length - 1);
        }
    }
}
