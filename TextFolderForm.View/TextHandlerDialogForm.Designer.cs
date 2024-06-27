namespace TextFolderForm.View
{
    partial class TextHandlerDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            removerWhitespacesButton = new Button();
            registerManipulatorButton = new Button();
            swapLettersButton = new Button();
            sortWordsButton = new Button();
            saveTextButton = new Button();
            recognizeDateButton = new Button();
            SuspendLayout();
            // 
            // removerWhitespacesButton
            // 
            removerWhitespacesButton.Location = new Point(39, 26);
            removerWhitespacesButton.Name = "removerWhitespacesButton";
            removerWhitespacesButton.Size = new Size(236, 29);
            removerWhitespacesButton.TabIndex = 0;
            removerWhitespacesButton.Text = "Убрать пробелы(a)";
            removerWhitespacesButton.UseVisualStyleBackColor = true;
            removerWhitespacesButton.Click += removerWhitespacesButton_Click;
            // 
            // registerManipulatorButton
            // 
            registerManipulatorButton.Location = new Point(39, 72);
            registerManipulatorButton.Name = "registerManipulatorButton";
            registerManipulatorButton.Size = new Size(236, 29);
            registerManipulatorButton.TabIndex = 1;
            registerManipulatorButton.Text = "Поменять регистр(b)";
            registerManipulatorButton.UseVisualStyleBackColor = true;
            registerManipulatorButton.Click += registerManipulatorButton_Click;
            // 
            // swapLettersButton
            // 
            swapLettersButton.Location = new Point(39, 121);
            swapLettersButton.Name = "swapLettersButton";
            swapLettersButton.Size = new Size(236, 29);
            swapLettersButton.TabIndex = 2;
            swapLettersButton.Text = "Поменять буквы местами(c)";
            swapLettersButton.UseVisualStyleBackColor = true;
            swapLettersButton.Click += swapLettersButton_Click;
            // 
            // sortWordsButton
            // 
            sortWordsButton.Location = new Point(39, 166);
            sortWordsButton.Name = "sortWordsButton";
            sortWordsButton.Size = new Size(236, 29);
            sortWordsButton.TabIndex = 3;
            sortWordsButton.Text = "Упорядочить слова(d)";
            sortWordsButton.UseVisualStyleBackColor = true;
            sortWordsButton.Click += sortWordsButton_Click;
            // 
            // saveTextButton
            // 
            saveTextButton.Location = new Point(39, 214);
            saveTextButton.Name = "saveTextButton";
            saveTextButton.Size = new Size(236, 29);
            saveTextButton.TabIndex = 4;
            saveTextButton.Text = "Сохранить текст(e)";
            saveTextButton.UseVisualStyleBackColor = true;
            saveTextButton.Click += saveTextButton_Click;
            // 
            // recognizeDateButton
            // 
            recognizeDateButton.Location = new Point(39, 259);
            recognizeDateButton.Name = "recognizeDateButton";
            recognizeDateButton.Size = new Size(236, 29);
            recognizeDateButton.TabIndex = 5;
            recognizeDateButton.Text = "Распознать дату(f)";
            recognizeDateButton.UseVisualStyleBackColor = true;
            recognizeDateButton.Click += recognizeDateButton_Click;
            // 
            // TextHandlerDialogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 309);
            Controls.Add(recognizeDateButton);
            Controls.Add(saveTextButton);
            Controls.Add(sortWordsButton);
            Controls.Add(swapLettersButton);
            Controls.Add(registerManipulatorButton);
            Controls.Add(removerWhitespacesButton);
            Name = "TextHandlerDialogForm";
            Text = "TextHandlerDialogForm";
            ResumeLayout(false);
        }

        #endregion

        private Button removerWhitespacesButton;
        private Button registerManipulatorButton;
        private Button swapLettersButton;
        private Button sortWordsButton;
        private Button saveTextButton;
        private Button recognizeDateButton;
    }
}