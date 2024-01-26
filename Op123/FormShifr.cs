using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Op123
{
    public partial class FormShifr : Form
    {
        public FormShifr()
        {
            InitializeComponent();
        }

        private void DiamCh_ValueChanged(object sender, EventArgs e)
        {
            if ((MainText.Text.Length > 0) && (RazshivText.MaxLength > 0))
            {
                Scitala sc = new Scitala((int)DiamCh.Value);
                RazshivText.Text = sc.Decrypt(MainText.Text);
            }
        }

        private void buttonZash_Click(object sender, EventArgs e)
        {
            int di = (int)DiamCh.Value;
            if (IshodText.Text.Length <= di) //длина текста должна быть больше ключа шифрования
            {
                MessageBox.Show("Короткий текст для шифрования");
                return;
            }
            Scitala sc = new Scitala(di);
            MainText.Text = sc.Encrypt(IshodText.Text); // вызов функции шифрования
            RazshivText.Text = sc.Decrypt(MainText.Text); // вызов функции дешифрования для контроля
            ////Данные входящие в подсказку: 
            //EncTimeStamp = DateTime.Now.ToString();
            //EncLabel.Text = RegUser + ", " + EncTimeStamp + ", Ключ= " + DiamCh.Value.ToString();
            //EncrFBox.Text = "(Ещё не сохранён)";
        }

        private void buttonSaveSh_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = ".txt";
            savefile.Filter = "Test files|*.txt";
            if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK && savefile.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName, true))
                {
                    sw.WriteLine(MainText.Text);
                    sw.Close();
                }
            }
        }

        private void ZashCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog readfile = new OpenFileDialog();
            if (readfile.ShowDialog() == DialogResult.OK)
            {
                Name = readfile.FileName;
                IshodText.Clear();
                   
                IshodText.Text = File.ReadAllText(Name);
                
            }
        }
    }
}
