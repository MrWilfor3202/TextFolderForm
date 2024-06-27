using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFolderForm.Model.Extensions
{
    internal static class StringExtensions
    {
        internal static string[] SplitAndKeepDelimiters(this string str, char delimiter)
        {
            return Regex.Split(str, $"({Regex.Escape(delimiter.ToString())}+)");
        }

        internal static string[] SplitAndKeepDelimiters(this string str, char[] delimiter)
        {
            string delimitersStr = "";

            foreach ( char c in delimiter ) 
                delimitersStr += c + " ";

            delimitersStr.Remove(delimiter.Length - 1, 1);

            return Regex.Split(str, $"({Regex.Escape(new string(delimiter))}+)");
        }
    }
}
