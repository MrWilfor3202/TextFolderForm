using TextFolderForm.Model.Handlers.Abstract.Text;
using TextFolderForm.Model.Handlers.Utils;

namespace TextFolderForm.Model.Handlers.Implementations.Text
{
    public class RemoverWhitespaces : ITextHandler
    {
        public string HandleText(string text)
        {
            var charsWithoutWhitespaces = text.Split(ConstantStorage.Separators, StringSplitOptions.RemoveEmptyEntries)
                .SelectMany(word => word)
                .ToArray();

            return new string(charsWithoutWhitespaces);
        }
    }
}
