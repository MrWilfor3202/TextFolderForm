using System.Text;
using System.Text.RegularExpressions;
using TextFolderForm.Model.Handlers.Abstract.Text;
using TextFolderForm.Model.Extensions;
using TextFolderForm.Model.Handlers.Utils;

namespace TextFolderForm.Model.Handlers.Implementations.Text
{
    public class RegisterManipulator : ITextHandler
    {
        public string HandleText(string text)
        {
            var result = Regex.Split(text, @"(?<=[. \n \t \r])")
                .SelectMany(ch => CapitalizeFirstLetter(ch))
                .ToArray();

            return new string(result);
        }

        private string CapitalizeFirstLetter(string word) 
        {
            var wordSB = new StringBuilder(word);
            
            if(wordSB.Length > 0) 
                wordSB[0] = Char.ToUpper(wordSB[0]);

            return wordSB.ToString();
        }
    }
}
