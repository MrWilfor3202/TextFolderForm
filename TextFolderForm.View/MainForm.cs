using TextFolderForm.ViewModel.ViewModel;

namespace TextFolderForm.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataContext = new MainViewModel();

            inputTextBox.DataBindings.Add(
                new Binding("Text", DataContext, "InputText", false, DataSourceUpdateMode.OnPropertyChanged));

            outputTextBox.DataBindings.Add(
                new Binding("Text", DataContext, "OutputText", false, DataSourceUpdateMode.OnPropertyChanged));

            selectedFolderPathTextBox.DataBindings.Add(
                new Binding("Text", DataContext, "SelectedFolderPath", false, DataSourceUpdateMode.OnPropertyChanged));

            resultTextBox.DataBindings.Add(
                new Binding("Text", DataContext, "OperationResult", false, DataSourceUpdateMode.OnPropertyChanged));

            removerFolderButton.DataBindings.Add(new Binding("Command", DataContext, "EraseFoldersCommand", true));
            sortFilesButton.DataBindings.Add(new Binding("Command", DataContext, "SortFoldersByExtensionsCommand", true));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void handlerButton_Click(object sender, EventArgs e)
        {
            using (TextHandlerDialogForm handlerForm = new TextHandlerDialogForm())
            {
                handlerForm.SetDataContext(DataContext);
                handlerForm.ShowDialog();
            }
        }

        private void selecterFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var folder = folderBrowserDialog.SelectedPath;
                selectedFolderPathTextBox.Text = folder;
                resultTextBox.Text = "Выберите действие";
            }
        }
    }
}