using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TextFolderForm.Model.Handlers.Abstract.Folders;
using TextFolderForm.Model.Handlers.Abstract.Text;
using TextFolderForm.Model.Handlers.Implementations.Folders;
using TextFolderForm.Model.Handlers.Implementations.Text;
using TextFolderForm.Model.Logger.Implementations;

namespace TextFolderForm.ViewModel.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _inputText;
        private string _outputText;
        private string _selectedFolderPath;
        private string _operationResult;
        private ITextHandler _textHandler;
        private IFoldersHandler _folderHandler;

        public string InputText 
        { 
            get => _inputText;
            set 
            { 
                if (_inputText != value) 
                {
                    _inputText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string OutputText
        {
            get => _outputText;
            set
            {
                if (_outputText != value)
                {
                    _outputText = value;
                    OnPropertyChanged();
                }
            }
        }

        public string SelectedFolderPath
        {
            get => _selectedFolderPath;
            set
            {
                if (_selectedFolderPath != value)
                {
                    _selectedFolderPath = value;
                    OnPropertyChanged();
                }
            }
        }

        public string OperationResult
        {
            get => _operationResult;
            set
            {
                if (_operationResult != value)
                {
                    _operationResult = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand RemoveWhitespacesCommand { get; set; } 
        public ICommand ManipulateRegisterCommand { get; set; } 
        public ICommand SwapLettersCommand { get; set; } 
        public ICommand WriteFileCommand { get; set; } 
        public ICommand RecognizeDateCommand { get; set; } 
        public ICommand SortWordsByAlphabetCommand { get; set; }
        public ICommand SortFoldersByExtensionsCommand { get; set; }
        public ICommand EraseFoldersCommand { get; set; }


        public MainViewModel() 
        {
            RemoveWhitespacesCommand = new MainCommand(_ =>
            {
                _textHandler = new RemoverWhitespaces();
                OutputText = _textHandler.HandleText(InputText);
            });

            ManipulateRegisterCommand = new MainCommand(_ =>
            {
                _textHandler = new RegisterManipulator();
                OutputText = _textHandler.HandleText(InputText);
            });

            SwapLettersCommand = new MainCommand(_ =>
            {
                _textHandler = new LettersSwaper();
                OutputText = _textHandler.HandleText(InputText);
            });

            WriteFileCommand = new MainCommand(_ =>
            {
                _textHandler = new FileWriter();
                OutputText = _textHandler.HandleText(InputText);
            });

            RecognizeDateCommand = new MainCommand(_ =>
            {
                _textHandler = new DateRecognizer();
                OutputText = _textHandler.HandleText(InputText);
            });

            SortWordsByAlphabetCommand = new MainCommand(_ =>
            {
                _textHandler = new AlphabetWordsSorter();
                OutputText = _textHandler.HandleText(InputText);
            });

            SortFoldersByExtensionsCommand = new MainCommand(_ =>
            {
                _folderHandler = new SelecterFolder(new FileLogger());
                OperationResult = _folderHandler.HandleFolders(SelectedFolderPath);
            });

            EraseFoldersCommand = new MainCommand(_ =>
            {
                if (SelectedFolderPath != "")
                {
                    _folderHandler = new FolderEraser(new FileLogger());
                    OperationResult = _folderHandler.HandleFolders(SelectedFolderPath);
                }
            });

            InputText = "";
            SelectedFolderPath = "";
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
