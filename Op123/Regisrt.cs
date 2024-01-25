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
            DBManager dBManager = new DBManager("C:\\Users\\kizar\\DBBBB.db");
            if (dBManager.AddUser(textBoxLogReg.Text, textBoxPassReg.Text))
            {
                MessageBox.Show("Усешно");
            }
            else
            {
                MessageBox.Show("Не удалось");
            }
            //if (dBManager.AddUser("C:\\Users\\kizar\\DBBBB.db", textBoxLog.Text, textBoxPass.Text))
            //{
            //    MessageBox.Show("Успешно");
            //}
            //else
            //{
            //    MessageBox.Show("Провал");
            //}
        }

        private void buttonAuthSwap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main_form = new Form1();
            main_form.ShowDialog();
        }
    }
}
