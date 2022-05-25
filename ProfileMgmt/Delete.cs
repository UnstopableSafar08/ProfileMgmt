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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
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
                MessageBox.Show("No Record was Found !!!", ("Delete Operation Message"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchId.Text = "";
                txtSearchId.Focus();
            }
        }
        private DataTable GetNameByStudentId(string id)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = " select * from Profile where Sid like @id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu aa = new menu();
            this.Hide();
            aa.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPname.Text = "";
            txtPc.Text = "";
            txtPadd.Text = "";
            txtPcor.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cbGender.SelectedIndex = 0;
            txtDate.Text = "";
            txtBatch.Text = "";
            cbPro.SelectedIndex = 0;
            cbFac.SelectedIndex = 0;
            cbNat.SelectedIndex = 0;
            txtSid.Text = "";
            txtSearchId.Text = "";

            txtDbms.Text = "";
            txtCs.Text = "";
            txtMm.Text = "";
            txtDms.Text = "";
            txtWeb.Text = "";
            txtCo.Text = "";
            txtTot.Text = "";
            txtObt.Text = "";
            txtPer.Text = "";
            txtRes.Text = "";
            txtName.Focus();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            cbPro.SelectedIndex = 0;
            cbFac.SelectedIndex = 0;
            cbNat.SelectedIndex = 0;
            LoadGrid();
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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPadd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPcor.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbGender.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtDate.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtBatch.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cbPro.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cbFac.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cbNat.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();

            txtDbms.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtCs.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtMm.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtDms.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            txtWeb.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            txtCo.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            txtTot.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            txtObt.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            txtPer.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            txtRes.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure, You want to Delete Record ???", ("Delete Button click Message"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "DELETE FROM Profile where Sid=@id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("Id", txtSid.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                txtDbms.Text = "";
                txtCs.Text = "";
                txtMm.Text = "";
                txtDms.Text = "";
                txtWeb.Text = "";
                txtCo.Text = "";
                txtTot.Text = "";
                txtObt.Text = "";
                txtPer.Text = "";
                txtRes.Text = "";

                txtName.Text = "";
                txtPname.Text = "";
                txtPc.Text = "";
                txtPadd.Text = "";
                txtPcor.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                cbGender.SelectedIndex = 0;
                txtDate.Text = "";
                txtBatch.Text = "";
                cbPro.SelectedIndex = 0;
                cbFac.SelectedIndex = 0;
                cbNat.SelectedIndex = 0;

                txtName.Focus();
                LoadGrid();
                MessageBox.Show("Data Deleted Succesfully !!!", ("Delete Operation Message"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }


}
