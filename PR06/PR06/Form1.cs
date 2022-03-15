using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR06;

namespace PR06
{
    public partial class Form1 : Form
    {
        string pathToEncrypt { get; set; }
        string pathToDecrypt { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void fileChoiceBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToEncrypt = fileDialog.FileName;
                fileForEncryptionPathTextBox.Text = fileDialog.FileName;
            }
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            if (firstPartOfKey.Enabled == false || secondPartOfKey.Enabled == false)
            {
                if (!File.Exists(fileForEncryptionPathTextBox.Text))
                {
                    MessageBox.Show("Некорретко указан файл для шифрования!" + "\n(Выбранный файл не существует)",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                // Получаем байты файла с размером блока в 64
                byte[] bytesOfFile = RSA.CovertBytesToRSA(File.ReadAllBytes(fileForEncryptionPathTextBox.Text));

                // Получаем простые числа в диапозоне от 2 до 100 (Получаем произведение и функцию Эйлера для чисел)
                RSA.GetPartOfKeys(3, 100);

                // Высчитываем открытый ключ e
                RSA.Calculate_e();
                // Высчитываем закрытый ключ d
                RSA.Calculate_d();

                // Производим шифрование файла
                RSA.EncryptMessage(bytesOfFile, fileForEncryptionPathTextBox.Text);

                if (RSA.n != 0)
                {
                    string str = "Шифрование успешно завершено!\nКлючи:\t" + RSA.p + "\t" + RSA.q;
                    MessageBox.Show(str,
                                "Внимание!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                }
            }
            else
            {
                if (!File.Exists(fileForEncryptionPathTextBox.Text))
                {
                    MessageBox.Show("Некорретко указан файл для шифрования!" + "\n(Выбранный файл не существует)",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                // Получаем байты файла с размером блока в 64
                byte[] bytesOfFile = RSA.CovertBytesToRSA(File.ReadAllBytes(fileForEncryptionPathTextBox.Text));

                // Получаем простые числа в диапозоне от 2 до 100 (Получаем произведение и функцию Эйлера для чисел)
                ulong p = Convert.ToUInt64(firstPartOfKey.Value);
                ulong q = Convert.ToUInt32(secondPartOfKey.Value);
                RSA.SetPartOfKeys(p, q); // Пример открытых ключей: 17 11

                // Высчитываем открытый ключ e
                RSA.Calculate_e();
                // Высчитываем закрытый ключ d
                RSA.Calculate_d();

                // Производим шифрование файла
                RSA.EncryptMessage(bytesOfFile, fileForEncryptionPathTextBox.Text);

                if (RSA.n != 0)
                {
                    string str = "Шифрование успешно завершено!\nКлючи" + RSA.p + RSA.q;
                    MessageBox.Show(str,
                                "Внимание!",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            firstPartOfKey.Enabled = !firstPartOfKey.Enabled;
            secondPartOfKey.Enabled = !secondPartOfKey.Enabled;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            if (firstPartOfKey.Enabled == false && secondPartOfKey.Enabled == false)
            {
                // Проверка на корректность выбранного файла
                if (!File.Exists(fileForDecryptionPathTextBox.Text))
                {
                    MessageBox.Show("Некорретко указан файл для расшифрования!\n(Выбранный файл не существует)",
                                     "Ошибка",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    return;
                }

                // Расшифровываем файл и сохраняем результат
                RSA.DecryptMessage(File.ReadAllBytes(fileForDecryptionPathTextBox.Text), fileForDecryptionPathTextBox.Text);

                MessageBox.Show("Дефрование успешно завершено!");
            }
            else
            {
                ulong p = Convert.ToUInt64(firstPartOfKey.Value);
                ulong q = Convert.ToUInt32(secondPartOfKey.Value);
                RSA.SetPartOfKeys(p, q); // Пример открытых ключей: 17 11

                // Высчитываем открытый ключ e
                RSA.Calculate_e();
                // Высчитываем закрытый ключ d
                RSA.Calculate_d();

                // Проверка на корректность выбранного файла
                if (!File.Exists(fileForDecryptionPathTextBox.Text))
                {
                    MessageBox.Show("Некорретко указан файл для расшифрования!\n(Выбранный файл не существует)",
                                     "Ошибка",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    return;
                }

                // Расшифровываем файл и сохраняем результат
                RSA.DecryptMessage(File.ReadAllBytes(fileForDecryptionPathTextBox.Text), fileForDecryptionPathTextBox.Text);

                MessageBox.Show("Дефрование успешно завершено!");
            }
        }

        private void openFileToDecrypt(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileForDecryptionPathTextBox.Text = fileDialog.FileName;
            }
        }
    }
}
