using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFolderForm.Model.Logger.Abstract
{
    public interface ILogger
    {
        void Log(string message);
    }
}
