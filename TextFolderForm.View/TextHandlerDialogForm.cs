using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFolderForm.View
{
    public partial class TextHandlerDialogForm : Form
    {
        public TextHandlerDialogForm()
        {
            InitializeComponent();
        }

        public void SetDataContext(object context)
        {
            DataContext = context;
            removerWhitespacesButton.DataBindings.Add(new Binding("Command", DataContext, "RemoveWhitespacesCommand", true));
            registerManipulatorButton.DataBindings.Add(new Binding("Command", DataContext, "ManipulateRegisterCommand", true));
            saveTextButton.DataBindings.Add(new Binding("Command", DataContext, "WriteFileCommand", true));
            swapLettersButton.DataBindings.Add(new Binding("Command", DataContext, "SwapLettersCommand", true));
            recognizeDateButton.DataBindings.Add(new Binding("Command", DataContext, "RecognizeDateCommand", true));
            sortWordsButton.DataBindings.Add(new Binding("Command", DataContext, "SortWordsByAlphabetCommand", true));
        }

        private void removerWhitespacesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registerManipulatorButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapLettersButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sortWordsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveTextButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void recognizeDateButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
