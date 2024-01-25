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
            //if (new User(textBoxLog.Text, textBoxPass.Text).CheckUser())
            //{
            //    this.Hide();
            //    var formMain = new FormMain();
            //    formMain.Closed += (s, args) => this.Close();
            //    formMain.Show();
            //}
            //else
            //{
            //    this.Close();
            //}
            string login = textBoxLog.Text;
            if (login.Contains('\'') || login.Contains('-'))
            {

                MessageBox.Show("Логин содержить недопустимые символы");
                return;
            }
        }

        private void buttonRegSwap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regisrt reg_form = new Regisrt();
            reg_form.ShowDialog();
        }
    }
}

