using PRN_ASG.Setting;
using PRN_ASG2.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_ASG
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            string usernameConfig = new ReadSetting().readUserSetting("Username");
            string passwordConfig = new ReadSetting().readUserSetting("Password");

            if (username == usernameConfig && password == passwordConfig)
            {
                new MainGUI(true).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dont have that user!");
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            new MainGUI().Show();
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
