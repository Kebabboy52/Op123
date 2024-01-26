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
    public partial class Regisrt : Form
    {
        public Regisrt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string username = textBoxLogReg.Text;
            string password = textBoxPassReg.Text;
            string confirmPassword = textRepeatPass.Text;

            if (password == confirmPassword)
            {
                // Пароли совпадают, выполняем регистрацию
                // TODO: Добавьте код для регистрации пользователя
                MessageBox.Show("Регистрация успешно выполнена!");

                if (string.IsNullOrWhiteSpace(textBoxLogReg.Text) || string.IsNullOrWhiteSpace(textBoxPassReg.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    return;
                }

                DBManager dBManager = new DBManager("C:\\Users\\kizar\\DBBBB.db");
                if (dBManager.AddUser(textBoxLogReg.Text, textBoxPassReg.Text))
                {
                    MessageBox.Show("Успешно");
                }
                else
                {
                    MessageBox.Show("Не удалось");
                }
            }
            else
            {
                // Пароли не совпадают, выводим сообщение об ошибке
                MessageBox.Show("Пароли не совпадают. Пожалуйста, повторите ввод.");
            }

            ////bool hasCif = false; //есть ли цифры
            ////bool hasAlp = false; //есть ли латинские буквы
            ////for (int i = 0; i < textBoxPassReg.Text.Length; i++)
            ////{
            ////    hasCif = hasCif || ((textBoxPassReg.Text[i] >= '0') && (textBoxPassReg.Text[i] <= '9'));
            ////    hasAlp = hasAlp || ((textBoxPassReg.Text[i] >= 'a') && (textBoxPassReg.Text[i] <= 'z')) ||
            ////        ((textBoxPassReg.Text[i] >= 'A') && (textBoxPassReg.Text[i] <= 'Z'));
            ////}
            //////Получили: есть или нет цифры, есть или нет латинские буквы (отдельными 2-мя переменными)


            ////if (String.IsNullOrWhiteSpace(textBoxLogReg.Text) ||
            ////    String.IsNullOrWhiteSpace(textBoxPassReg.Text) ||
            ////    String.IsNullOrWhiteSpace(textRepeatPass.Text))
            ////{
            ////    MessageBox.Show("Есть неверные (пустые?) поля");
            ////    return;
            ////}
            ////else if (textBoxPassReg.Text.Length < 8)
            ////{
            ////    MessageBox.Show("Пароль менее 8 символов");
            ////    return;
            ////}
            ////else if (!(hasCif & hasAlp))
            ////{
            ////    MessageBox.Show("В пароле требуются лат.буквы и цифры");
            ////    return;
            ////}
            ////else if (textBoxPassReg.Text != textRepeatPass.Text)
            ////{
            ////    MessageBox.Show("Два пароля не совпадают");
            ////    return;
            ////}
            ////else
            ////{


            ////    this.DialogResult = DialogResult.OK;
            ////    this.Close(); //закрываем форму регистрации
            ////}
        }

                                   

        private void buttonAuthSwap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main_form = new Form1();
            main_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
