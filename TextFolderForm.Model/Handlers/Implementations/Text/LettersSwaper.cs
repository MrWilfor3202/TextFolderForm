using System.Text;
using System.Text.RegularExpressions;
using TextFolderForm.Model.Handlers.Abstract.Text;
using TextFolderForm.Model.Handlers.Utils;

namespace TextFolderForm.Model.Handlers.Implementations.Text
{
    public class LettersSwaper : ITextHandler
    {
        public string HandleText(string text)
        {
            var result = Regex.Split(text, @"([ ,.\n\t\r])")
                .SelectMany(word => SwapFirstAndLastLetter(word))
                .ToArray();

            return new string(result);
        }

        private string SwapFirstAndLastLetter(string word)
        {
            var wordSB = new StringBuilder(word);

            if (wordSB.Length <= 0)
                return word;

            if (!Char.IsLetter(wordSB[0]) || !Char.IsLetter(wordSB[^1]))
                return word;

            char chBackup = wordSB[0];
            wordSB[0] = wordSB[^1];
            wordSB[^1] = chBackup;

            return wordSB.ToString();
        }
    }
}
