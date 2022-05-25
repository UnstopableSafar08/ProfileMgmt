using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProfileMgmt
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.btnViewMenu.Focus();
            StdInfo aa = new StdInfo();
            this.Hide();
            aa.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View aa = new View();
            this.Hide();
            aa.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //
            Application.Exit();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            Login aa = new Login();
            this.Hide();
            aa.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            btnCreateMenu.Focus();
            RowCount();

        }
        private void RowCount()
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select * from Profile";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TotRowCount.Text = dt.Rows.Count.ToString();
        }
        private void btnSearchMenu_Click(object sender, EventArgs e)
        {
            Search aa = new Search();
            this.Hide();
            aa.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update aa = new Update();
            this.Hide();
            aa.ShowDialog();
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            Delete aa = new Delete();
            this.Hide();
            aa.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
