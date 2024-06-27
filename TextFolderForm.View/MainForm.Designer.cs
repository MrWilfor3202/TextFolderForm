namespace TextFolderForm.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            handlerTabs = new TabControl();
            textHandlerTab = new TabPage();
            outputLabel = new Label();
            inputLabel = new Label();
            handlerButton = new Button();
            outputTextBox = new TextBox();
            inputTextBox = new TextBox();
            folderHandlerTab = new TabPage();
            resultTextBox = new TextBox();
            resultLabel = new Label();
            sortFilesButton = new Button();
            selectedFolderLabel = new Label();
            selectedFolderPathTextBox = new TextBox();
            removerFolderButton = new Button();
            selecterFolderButton = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            handlerTabs.SuspendLayout();
            textHandlerTab.SuspendLayout();
            folderHandlerTab.SuspendLayout();
            SuspendLayout();
            // 
            // handlerTabs
            // 
            handlerTabs.Controls.Add(textHandlerTab);
            handlerTabs.Controls.Add(folderHandlerTab);
            handlerTabs.Location = new Point(1, -2);
            handlerTabs.Name = "handlerTabs";
            handlerTabs.SelectedIndex = 0;
            handlerTabs.Size = new Size(634, 351);
            handlerTabs.TabIndex = 0;
            // 
            // textHandlerTab
            // 
            textHandlerTab.Controls.Add(outputLabel);
            textHandlerTab.Controls.Add(inputLabel);
            textHandlerTab.Controls.Add(handlerButton);
            textHandlerTab.Controls.Add(outputTextBox);
            textHandlerTab.Controls.Add(inputTextBox);
            textHandlerTab.Location = new Point(4, 29);
            textHandlerTab.Name = "textHandlerTab";
            textHandlerTab.Padding = new Padding(3);
            textHandlerTab.Size = new Size(626, 318);
            textHandlerTab.TabIndex = 0;
            textHandlerTab.Text = "Обработчики текста";
            textHandlerTab.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(266, 104);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(57, 20);
            outputLabel.TabIndex = 4;
            outputLabel.Text = "Вывод:";
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(266, 28);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(46, 20);
            inputLabel.TabIndex = 3;
            inputLabel.Text = "Ввод:";
            // 
            // handlerButton
            // 
            handlerButton.Location = new Point(143, 214);
            handlerButton.Name = "handlerButton";
            handlerButton.Size = new Size(315, 29);
            handlerButton.TabIndex = 2;
            handlerButton.Text = "Обработать текст";
            handlerButton.UseVisualStyleBackColor = true;
            handlerButton.Click += handlerButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(112, 127);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.Size = new Size(386, 27);
            outputTextBox.TabIndex = 1;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(112, 51);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(386, 27);
            inputTextBox.TabIndex = 0;
            // 
            // folderHandlerTab
            // 
            folderHandlerTab.Controls.Add(resultTextBox);
            folderHandlerTab.Controls.Add(resultLabel);
            folderHandlerTab.Controls.Add(sortFilesButton);
            folderHandlerTab.Controls.Add(selectedFolderLabel);
            folderHandlerTab.Controls.Add(selectedFolderPathTextBox);
            folderHandlerTab.Controls.Add(removerFolderButton);
            folderHandlerTab.Controls.Add(selecterFolderButton);
            folderHandlerTab.Location = new Point(4, 29);
            folderHandlerTab.Name = "folderHandlerTab";
            folderHandlerTab.Padding = new Padding(3);
            folderHandlerTab.Size = new Size(626, 318);
            folderHandlerTab.TabIndex = 1;
            folderHandlerTab.Text = "Обработчики папок";
            folderHandlerTab.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(150, 99);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(372, 27);
            resultTextBox.TabIndex = 6;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(261, 76);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(149, 20);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "Результат операции";
            // 
            // sortFilesButton
            // 
            sortFilesButton.Location = new Point(150, 216);
            sortFilesButton.Name = "sortFilesButton";
            sortFilesButton.Size = new Size(377, 29);
            sortFilesButton.TabIndex = 4;
            sortFilesButton.Text = "Отсортировать по расширениям";
            sortFilesButton.UseVisualStyleBackColor = true;
            // 
            // selectedFolderLabel
            // 
            selectedFolderLabel.AutoSize = true;
            selectedFolderLabel.Cursor = Cursors.No;
            selectedFolderLabel.Location = new Point(246, 13);
            selectedFolderLabel.Name = "selectedFolderLabel";
            selectedFolderLabel.Size = new Size(182, 20);
            selectedFolderLabel.TabIndex = 3;
            selectedFolderLabel.Text = "Путь к выбранной папке";
            // 
            // selectedFolderPathTextBox
            // 
            selectedFolderPathTextBox.Location = new Point(150, 36);
            selectedFolderPathTextBox.Name = "selectedFolderPathTextBox";
            selectedFolderPathTextBox.ReadOnly = true;
            selectedFolderPathTextBox.Size = new Size(372, 27);
            selectedFolderPathTextBox.TabIndex = 2;
            // 
            // removerFolderButton
            // 
            removerFolderButton.Location = new Point(150, 264);
            removerFolderButton.Name = "removerFolderButton";
            removerFolderButton.Size = new Size(374, 29);
            removerFolderButton.TabIndex = 1;
            removerFolderButton.Text = "Очистить папку";
            removerFolderButton.UseVisualStyleBackColor = true;
            // 
            // selecterFolderButton
            // 
            selecterFolderButton.Location = new Point(150, 163);
            selecterFolderButton.Name = "selecterFolderButton";
            selecterFolderButton.Size = new Size(377, 29);
            selecterFolderButton.TabIndex = 0;
            selecterFolderButton.Text = "Выбрать папку";
            selecterFolderButton.UseVisualStyleBackColor = true;
            selecterFolderButton.Click += selecterFolder_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 355);
            Controls.Add(handlerTabs);
            Name = "MainForm";
            Text = "Обработчик текста/папок";
            Load += MainForm_Load;
            handlerTabs.ResumeLayout(false);
            textHandlerTab.ResumeLayout(false);
            textHandlerTab.PerformLayout();
            folderHandlerTab.ResumeLayout(false);
            folderHandlerTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl handlerTabs;
        private TabPage textHandlerTab;
        private Label outputLabel;
        private Label inputLabel;
        private Button handlerButton;
        private TextBox outputTextBox;
        private TextBox inputTextBox;
        private TabPage folderHandlerTab;
        private Button removerFolderButton;
        private Button selecterFolderButton;
        private FolderBrowserDialog folderBrowserDialog;
        private Label selectedFolderLabel;
        private TextBox selectedFolderPathTextBox;
        private Button sortFilesButton;
        private TextBox resultTextBox;
        private Label resultLabel;
    }
}