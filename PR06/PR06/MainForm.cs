using PR06;
using System;
using System.IO;
using System.Windows.Forms;

namespace PR06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FileForEncryptionPathButtonOnClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileForEncryptionPathTextBox.Text = fileDialog.FileName;
            }
        }

        private void EncryptedFilePathButtonOnClick(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                encryptedFilePathTextBox.Text = fileDialog.FileName;
            }
        }

        private void FileForDecryptionPathButtonOnClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileForDecryptionPathTextBox.Text = fileDialog.FileName;
            }
        }

        private void DecryptedFilePathButtonOnClick(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                decryptedFilePathTextBox.Text = fileDialog.FileName;
            }
        }

        private void EncryptFileButtonOnClick(object sender, EventArgs e)
        {
            // Проверка на корректность выбранного файла
            if (!File.Exists(fileForEncryptionPathTextBox.Text))
            {
                PrintError("Некорретко указан файл для шифрования!" +
                    "\n(Выбранный файл не существует)");
                return;
            }

            // Проверка, что пользователь ввёл хоть что-то в названии сохраняемого файла
            if (string.IsNullOrEmpty(encryptedFilePathTextBox.Text))
            {
                PrintError("Некорретко указан зашифрованный файл (результат шифрования)!");
                return;
            }

            // Получаем байты файла с размером блока в 64
            byte[] bytesOfFile = RSA.CovertBytesToRSA(File.ReadAllBytes(fileForEncryptionPathTextBox.Text));

            // Получаем простые числа в диапозоне от 2 до 100 (Получаем произведение и функцию Эйлера для чисел)
            RSA.GetPartOfKeys(2, 100);

            // Высчитываем открытый ключ e
            RSA.Calculate_e();
            // Высчитываем закрытый ключ d
            RSA.Calculate_d();

            // Производим шифрование файла
            RSA.EncryptMessage(bytesOfFile, encryptedFilePathTextBox.Text);

            MessageBox.Show("Шифрование успешно завершено!",
                            "Внимание!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }

        private void DecryptFileButtonOnClick(object sender, EventArgs e)
        {
            // Проверка на корректность выбранного файла
            if (!File.Exists(fileForDecryptionPathTextBox.Text))
            {
                PrintError("Некорретко указан файл для расшифрования!" +
                           "\n(Выбранный файл не существует)");
                return;
            }

            // Проверка, что пользователь ввёл хоть что-то в названии сохраняемого файла
            if (string.IsNullOrEmpty(decryptedFilePathTextBox.Text))
            {
                PrintError("Некорретко указан расшифрованный файл!");
                return;
            }

            // Расшифровываем файл и сохраняем результат
            RSA.DecryptMessage(File.ReadAllBytes(fileForDecryptionPathTextBox.Text), decryptedFilePathTextBox.Text);

            MessageBox.Show("Test");
        }

        private void PrintError(string errorMessage)
        {
            MessageBox.Show(
                errorMessage,
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

    }
}
