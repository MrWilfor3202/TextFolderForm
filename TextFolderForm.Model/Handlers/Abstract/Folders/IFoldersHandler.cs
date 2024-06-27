using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFolderForm.Model.Handlers.Abstract.Folders
{
    public interface IFoldersHandler
    {
        string HandleFolders(string path);
    }
}
