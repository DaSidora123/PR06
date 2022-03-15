
namespace PR06
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileForEncryptionPathTextBox = new System.Windows.Forms.TextBox();
            this.fileForEncryptionPathButton = new System.Windows.Forms.Button();
            this.fileForEnryptionPathLabel = new System.Windows.Forms.Label();
            this.encryptFileButton = new System.Windows.Forms.Button();
            this.encryptedFilePathTextBox = new System.Windows.Forms.TextBox();
            this.encryptedFilePathTitleLabel = new System.Windows.Forms.Label();
            this.encryptedFilePathButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fileForDecryptionPathLabel = new System.Windows.Forms.Label();
            this.decryptFileButton = new System.Windows.Forms.Button();
            this.decryptedFilePathButton = new System.Windows.Forms.Button();
            this.decryptedFilePathTextBox = new System.Windows.Forms.TextBox();
            this.fileForDecryptionPathTextBox = new System.Windows.Forms.TextBox();
            this.fileForDecryptionPathButton = new System.Windows.Forms.Button();
            this.decryptedFilePathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileForEncryptionPathTextBox
            // 
            this.fileForEncryptionPathTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileForEncryptionPathTextBox.Location = new System.Drawing.Point(13, 43);
            this.fileForEncryptionPathTextBox.Name = "fileForEncryptionPathTextBox";
            this.fileForEncryptionPathTextBox.Size = new System.Drawing.Size(359, 26);
            this.fileForEncryptionPathTextBox.TabIndex = 1;
            // 
            // fileForEncryptionPathButton
            // 
            this.fileForEncryptionPathButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileForEncryptionPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileForEncryptionPathButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileForEncryptionPathButton.Location = new System.Drawing.Point(378, 43);
            this.fileForEncryptionPathButton.Name = "fileForEncryptionPathButton";
            this.fileForEncryptionPathButton.Size = new System.Drawing.Size(57, 26);
            this.fileForEncryptionPathButton.TabIndex = 2;
            this.fileForEncryptionPathButton.Text = "...";
            this.fileForEncryptionPathButton.UseVisualStyleBackColor = false;
            this.fileForEncryptionPathButton.Click += new System.EventHandler(this.FileForEncryptionPathButtonOnClick);
            // 
            // fileForEnryptionPathLabel
            // 
            this.fileForEnryptionPathLabel.AutoSize = true;
            this.fileForEnryptionPathLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileForEnryptionPathLabel.Location = new System.Drawing.Point(13, 16);
            this.fileForEnryptionPathLabel.Name = "fileForEnryptionPathLabel";
            this.fileForEnryptionPathLabel.Size = new System.Drawing.Size(325, 24);
            this.fileForEnryptionPathLabel.TabIndex = 2;
            this.fileForEnryptionPathLabel.Text = "Выберите файл для шифрования";
            // 
            // encryptFileButton
            // 
            this.encryptFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.encryptFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptFileButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptFileButton.Location = new System.Drawing.Point(13, 160);
            this.encryptFileButton.Name = "encryptFileButton";
            this.encryptFileButton.Size = new System.Drawing.Size(422, 35);
            this.encryptFileButton.TabIndex = 5;
            this.encryptFileButton.Text = "Зашифровать файл";
            this.encryptFileButton.UseVisualStyleBackColor = false;
            this.encryptFileButton.Click += new System.EventHandler(this.EncryptFileButtonOnClick);
            // 
            // encryptedFilePathTextBox
            // 
            this.encryptedFilePathTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptedFilePathTextBox.Location = new System.Drawing.Point(13, 116);
            this.encryptedFilePathTextBox.Name = "encryptedFilePathTextBox";
            this.encryptedFilePathTextBox.Size = new System.Drawing.Size(359, 26);
            this.encryptedFilePathTextBox.TabIndex = 3;
            // 
            // encryptedFilePathTitleLabel
            // 
            this.encryptedFilePathTitleLabel.AutoSize = true;
            this.encryptedFilePathTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptedFilePathTitleLabel.Location = new System.Drawing.Point(13, 89);
            this.encryptedFilePathTitleLabel.Name = "encryptedFilePathTitleLabel";
            this.encryptedFilePathTitleLabel.Size = new System.Drawing.Size(329, 24);
            this.encryptedFilePathTitleLabel.TabIndex = 5;
            this.encryptedFilePathTitleLabel.Text = "Выберете путь сохранения файла";
            // 
            // encryptedFilePathButton
            // 
            this.encryptedFilePathButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.encryptedFilePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptedFilePathButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptedFilePathButton.Location = new System.Drawing.Point(378, 116);
            this.encryptedFilePathButton.Name = "encryptedFilePathButton";
            this.encryptedFilePathButton.Size = new System.Drawing.Size(57, 26);
            this.encryptedFilePathButton.TabIndex = 4;
            this.encryptedFilePathButton.Text = "...";
            this.encryptedFilePathButton.UseVisualStyleBackColor = false;
            this.encryptedFilePathButton.Click += new System.EventHandler(this.EncryptedFilePathButtonOnClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fileForEnryptionPathLabel);
            this.splitContainer1.Panel1.Controls.Add(this.encryptedFilePathButton);
            this.splitContainer1.Panel1.Controls.Add(this.fileForEncryptionPathTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.encryptedFilePathTitleLabel);
            this.splitContainer1.Panel1.Controls.Add(this.fileForEncryptionPathButton);
            this.splitContainer1.Panel1.Controls.Add(this.encryptedFilePathTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.encryptFileButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fileForDecryptionPathLabel);
            this.splitContainer1.Panel2.Controls.Add(this.decryptFileButton);
            this.splitContainer1.Panel2.Controls.Add(this.decryptedFilePathButton);
            this.splitContainer1.Panel2.Controls.Add(this.decryptedFilePathTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.fileForDecryptionPathTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.fileForDecryptionPathButton);
            this.splitContainer1.Panel2.Controls.Add(this.decryptedFilePathLabel);
            this.splitContainer1.Size = new System.Drawing.Size(917, 317);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 6;
            // 
            // fileForDecryptionPathLabel
            // 
            this.fileForDecryptionPathLabel.AutoSize = true;
            this.fileForDecryptionPathLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileForDecryptionPathLabel.Location = new System.Drawing.Point(19, 16);
            this.fileForDecryptionPathLabel.Name = "fileForDecryptionPathLabel";
            this.fileForDecryptionPathLabel.Size = new System.Drawing.Size(335, 24);
            this.fileForDecryptionPathLabel.TabIndex = 7;
            this.fileForDecryptionPathLabel.Text = "Выберите файл для расшифровки";
            // 
            // decryptFileButton
            // 
            this.decryptFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.decryptFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptFileButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptFileButton.Location = new System.Drawing.Point(19, 160);
            this.decryptFileButton.Name = "decryptFileButton";
            this.decryptFileButton.Size = new System.Drawing.Size(422, 35);
            this.decryptFileButton.TabIndex = 12;
            this.decryptFileButton.Text = "Расшифровать файл";
            this.decryptFileButton.UseVisualStyleBackColor = false;
            this.decryptFileButton.Click += new System.EventHandler(this.DecryptFileButtonOnClick);
            // 
            // decryptedFilePathButton
            // 
            this.decryptedFilePathButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.decryptedFilePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptedFilePathButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptedFilePathButton.Location = new System.Drawing.Point(384, 116);
            this.decryptedFilePathButton.Name = "decryptedFilePathButton";
            this.decryptedFilePathButton.Size = new System.Drawing.Size(57, 26);
            this.decryptedFilePathButton.TabIndex = 10;
            this.decryptedFilePathButton.Text = "...";
            this.decryptedFilePathButton.UseVisualStyleBackColor = false;
            this.decryptedFilePathButton.Click += new System.EventHandler(this.DecryptedFilePathButtonOnClick);
            // 
            // decryptedFilePathTextBox
            // 
            this.decryptedFilePathTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptedFilePathTextBox.Location = new System.Drawing.Point(19, 116);
            this.decryptedFilePathTextBox.Name = "decryptedFilePathTextBox";
            this.decryptedFilePathTextBox.Size = new System.Drawing.Size(359, 26);
            this.decryptedFilePathTextBox.TabIndex = 9;
            // 
            // fileForDecryptionPathTextBox
            // 
            this.fileForDecryptionPathTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileForDecryptionPathTextBox.Location = new System.Drawing.Point(19, 43);
            this.fileForDecryptionPathTextBox.Name = "fileForDecryptionPathTextBox";
            this.fileForDecryptionPathTextBox.Size = new System.Drawing.Size(359, 26);
            this.fileForDecryptionPathTextBox.TabIndex = 6;
            // 
            // fileForDecryptionPathButton
            // 
            this.fileForDecryptionPathButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fileForDecryptionPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileForDecryptionPathButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileForDecryptionPathButton.Location = new System.Drawing.Point(384, 43);
            this.fileForDecryptionPathButton.Name = "fileForDecryptionPathButton";
            this.fileForDecryptionPathButton.Size = new System.Drawing.Size(57, 26);
            this.fileForDecryptionPathButton.TabIndex = 8;
            this.fileForDecryptionPathButton.Text = "...";
            this.fileForDecryptionPathButton.UseVisualStyleBackColor = false;
            this.fileForDecryptionPathButton.Click += new System.EventHandler(this.FileForDecryptionPathButtonOnClick);
            // 
            // decryptedFilePathLabel
            // 
            this.decryptedFilePathLabel.AutoSize = true;
            this.decryptedFilePathLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptedFilePathLabel.Location = new System.Drawing.Point(19, 89);
            this.decryptedFilePathLabel.Name = "decryptedFilePathLabel";
            this.decryptedFilePathLabel.Size = new System.Drawing.Size(329, 24);
            this.decryptedFilePathLabel.TabIndex = 11;
            this.decryptedFilePathLabel.Text = "Выберете путь сохранения файла";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 317);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическая работа №6";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fileForEncryptionPathTextBox;
        private System.Windows.Forms.Button fileForEncryptionPathButton;
        private System.Windows.Forms.Label fileForEnryptionPathLabel;
        private System.Windows.Forms.Button encryptFileButton;
        private System.Windows.Forms.TextBox encryptedFilePathTextBox;
        private System.Windows.Forms.Label encryptedFilePathTitleLabel;
        private System.Windows.Forms.Button encryptedFilePathButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label fileForDecryptionPathLabel;
        private System.Windows.Forms.Button decryptFileButton;
        private System.Windows.Forms.Button decryptedFilePathButton;
        private System.Windows.Forms.TextBox decryptedFilePathTextBox;
        private System.Windows.Forms.TextBox fileForDecryptionPathTextBox;
        private System.Windows.Forms.Button fileForDecryptionPathButton;
        private System.Windows.Forms.Label decryptedFilePathLabel;
    }
}

