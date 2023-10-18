using PRN_ASG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN_ASG2.GUI
{
    public partial class MainGUI : Form
    {
        private Boolean isLogined = false;
        public MainGUI()
        {
            InitializeComponent();
        }
        public MainGUI(Boolean isLogined)
        {
            InitializeComponent();
            this.isLogined = isLogined;
        }

        private void login_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            if (isLogined)
            {
                login.Hide();
            }
            else
            {
                logout.Hide();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new MainGUI().Show();
            this.Hide();
            MessageBox.Show("You are logged out!");
        }

        private void show_Click(object sender, EventArgs e)
        {
            /*if (!isLogined)
            {
                MessageBox.Show("You need login to show!");
            } else
            {
                new ShowGUI().Show();
                this.Hide() ;
            }*/
            new ShowGUI().Show();
            this.Hide();
        }
    }
}
