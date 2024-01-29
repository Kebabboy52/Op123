namespace Op123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSeePass_Click(object sender, EventArgs e)
        {

            //обработка события при нажатии на кнопку показать/скрыть пароль
            if (textBoxPass.PasswordChar == '*')
            {
                textBoxPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPass.PasswordChar = '*';
            }
        }

        private void buttonEnterReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLog.Text) || string.IsNullOrWhiteSpace(textBoxPass.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }
            string login = textBoxLog.Text;
            if (login.Contains('\'') || login.Contains('-'))
            {

                MessageBox.Show("Логин содержить недопустимые символы");
                return;
            }

            DBManager dBManager = new DBManager("C:\\Users\\kizar\\DBBBB.db");
            if (dBManager.CheckUser(textBoxLog.Text, textBoxPass.Text))
            {

                MessageBox.Show("Успешно");
                FormShifr formShifr1 = new FormShifr();
                formShifr1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Не удалось");
            }
          
            
            
        }

        private void buttonRegSwap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regisrt reg_form = new Regisrt();
            reg_form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

