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
    public partial class Student_Data : Form
    {
        public Student_Data()
        {
            InitializeComponent();
        }

        private void Student_Data_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex=0;
            cbPro.SelectedIndex = 0;
            cbFac.SelectedIndex = 0;
            cbNat.SelectedIndex = 0;
            LoadGrid();
        }

        private void LoadGrid()
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Focus();
        
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text != "Update Data")
            {
                SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
                string sql = "insert into Profile(Name,P_Name,P_Con,Permanent_Address,Correspondance_Address,Phone,Email,Gender,DOB,Batch,Program,Faculty,Semester,Sid) values(@n,@pn,@pc,@padd,@pcor,@ph,@e,@g,@dob,@b,@p,@f,@nat,@id)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
                cmd.Parameters.AddWithValue("@pn", txtPname.Text);
                cmd.Parameters.AddWithValue("@pc", txtPc.Text);
                cmd.Parameters.AddWithValue("@padd", txtPadd.Text);
                cmd.Parameters.AddWithValue("@pcor", txtPcor.Text);
                cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                cmd.Parameters.AddWithValue("@g", cbGender.Text);
                cmd.Parameters.AddWithValue("@dob",this.txtDate.Text);
                cmd.Parameters.AddWithValue("@b", txtBatch.Text);
                cmd.Parameters.AddWithValue("@p", cbPro.Text);
                cmd.Parameters.AddWithValue("@f", cbFac.Text);
                cmd.Parameters.AddWithValue("@nat", cbNat.Text);
                cmd.Parameters.AddWithValue("@id", txtSid.Text);

                con.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show(" Created Successfully !! ");
                }
                con.Close();
            }
            else
            {
                SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
                string sql = "update Profile set Name=@name,P_Name=@pname,P_Con=@pcont,Permanent_Address=@padds,Correspondance_Address=@pcorr,Phone=@phone,Email=@email,Gender=@gender,DOB=@dobu,Batch=@batch,Program=@program,Faculty=@faculty,Semester=@semester WHERE Sid=@id";
            
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@pname", txtPname.Text);
                cmd.Parameters.AddWithValue("@pcont", txtPc.Text);
                cmd.Parameters.AddWithValue("@padds", txtPadd.Text);
                cmd.Parameters.AddWithValue("@pcorr", txtPcor.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@gender", cbGender.Text);
                cmd.Parameters.AddWithValue("@dobu", txtDate.Text);
                cmd.Parameters.AddWithValue("@batch", txtBatch.Text);
                cmd.Parameters.AddWithValue("@program", cbPro.Text);
                cmd.Parameters.AddWithValue("@faculty", cbFac.Text);
                cmd.Parameters.AddWithValue("@semester", cbNat.Text);
                cmd.Parameters.AddWithValue("@id",txtSid.Text);

                con.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show(" Updated Successfully !! ");
                }
                con.Close();
               }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = GetNameByStudentName(txtSearch.Text);
            if (dt.Rows.Count>0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show(" No Record was Found!!! ");
                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }

        private DataTable GetNameByStudentName(string name)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Name=@name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Name like @name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", txtSearch.Text+"%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

      
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPname.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPc.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPadd.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPcor.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPhone.Text=dataGridView1.CurrentRow.Cells[6].Value.ToString();  
            txtEmail.Text=dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbGender.Text=dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtDate.Text=dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtBatch.Text=dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cbPro.Text=dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cbFac.Text=dataGridView1.CurrentRow.Cells[12].Value.ToString();
            cbNat.Text=dataGridView1.CurrentRow.Cells[13].Value.ToString();
           

            btnCreate.Text = "Update Data";
            btnDelete.Enabled = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text="";
            txtPname.Text="";
            txtPc.Text="";
            txtPadd.Text="";
            txtPcor.Text="";
            txtPhone.Text="";  
            txtEmail.Text="";
            cbGender.SelectedIndex=0;
            txtDate.Text="";
            txtBatch.Text="";
            cbPro.SelectedIndex=0;
            cbFac.SelectedIndex=0;
            cbNat.SelectedIndex=0;
            txtSearchId.Text = "";
            txtSearch.Text = "";
            txtSearchSem.Text = "";
            txtSid.Text = "";
   

            txtName.Focus();
            btnCreate.Text = " Create Record ";
            btnDelete.Enabled = false;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "DELETE FROM Profile where Sid=@id";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("Id",txtSid.Text);

            con.Open();

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
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

                txtName.Focus();
                btnCreate.Text = " Create Record ";
                btnDelete.Enabled = false;
                LoadGrid();
                MessageBox.Show(" Deleted Successfully !! ");
            }
            con.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtSid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show(" No Record was Found!!! ");
                txtSearchId.Text = "";
                txtSearchId.Focus();
            }
        }

        private DataTable GetNameByStudentId(string id)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Sid=@id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void txtSearchSem_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Semester like @sem";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@sem", txtSearchSem.Text + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSearchSem_Click(object sender, EventArgs e)
        {
            DataTable dt = GetNameByStudentSem(txtSearchSem.Text);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show(" No Record was Found!!! ");
                txtSearchSem.Text = "";
                txtSearchSem.Focus();
            }
        }

        private DataTable GetNameByStudentSem(string sem)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile where Semester=@sem";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@sem", sem);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
