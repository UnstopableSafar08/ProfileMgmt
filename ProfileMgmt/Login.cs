using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileMgmt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string[] usernames = { "", "1", "user2", "sagar", "safar", "admin" };
        string[] passwords = { "", "2", "sagar", "3130", "313081", "admin" };
        private void button1_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(txtUserName.Text) && passwords.Contains(txtPassword.Text) &&
              Array.IndexOf(usernames, txtUserName.Text) == Array.IndexOf(passwords, txtPassword.Text))
            {
                menu aa = new menu();
                this.Hide();
                aa.ShowDialog();
            }

            else
                MessageBox.Show("\t-----------------------------------------------------------\n\tUSER'S NAME AND PASSWORD DOES NOT \n\t\tMATCHED.!!!\n\t\tPLEASE TRY AGAIN.\n\t----------------------------------------------------------\n","Wrong Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);         
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
  
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
