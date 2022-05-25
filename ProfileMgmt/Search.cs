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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            LoadGrid();
            txtSearchId.Focus();
        }

        private void LoadGrid()
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select * from Profile";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private DataTable GetNameByStudentId(string id)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select * from Profile where Sid like @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Sid like @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", txtSearchId.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            DataTable dt = GetNameByStudentId(txtSearchId.Text);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Record Was Found !!!", ("Error Message"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchId.Text = "";
                txtSearchId.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            txtPh.Text = "";
            txtSearchId.Text = "";
            txtId.Text = "";
            cbSem.SelectedIndex = 0;
            txtBatch.Text = "";
            txtName.Text = "";

            LoadGrid();
            txtSearchId.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu aa = new menu();
            this.Hide();
            aa.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            if(txtId.Text=="")
            {
                MessageBox.Show("Please Enter Student's ID !!!", ("Searchig Invalid !!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return;
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter Student's Name !!!", ("Searchig Invalid !!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            else if (txtBatch.Text == "")
            {
                MessageBox.Show("Please Enter Student's Batch Year !!!", ("Searchig Invalid !!!"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBatch.Focus();
                return;
            }

            else if (this.cbSem.Text.ToString() == "Select Semester") //item unselected ,comboBox validation
            {
                MessageBox.Show("Please select Semester !!!", ("ComboBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSem.Focus();
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
                string sql = "select * from Profile where Sid='" + txtId.Text + "' and Name='" + txtName.Text + "' and Batch='" + txtBatch.Text + "' and Semester='" + cbSem.Text + "' ";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Record Was Found !!!", ("Error Message"), MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtId.Text = "";
                    txtId.Focus();
                }
            }
        }


      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Name like @n";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@n", textBox1.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Email like @e";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@e", textBox2.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtPh_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Phone like @p";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@p", txtPh.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBatch_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

    }
}
