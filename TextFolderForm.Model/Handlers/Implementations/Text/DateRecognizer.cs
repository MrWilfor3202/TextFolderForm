using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFolderForm.Model.Handlers.Abstract.Text;

namespace TextFolderForm.Model.Handlers.Implementations.Text
{
    public class DateRecognizer : ITextHandler
    {
        public string HandleText(string text)
        {
            try
            {
                DateTime dateTime = DateTime.Parse(text);
                DateOnly date = DateOnly.FromDateTime(dateTime);
                int differenceInDays = (DateTime.Now - dateTime).Days;
                string result = $"{date.Day}-{date.Month}-{date.Year}, {date.DayOfWeek}, {Math.Abs(differenceInDays)}";
                return result;
            } 
            catch(FormatException e)
            {
                return "Невозможно распознать дату";
            }
        }
    }
}
