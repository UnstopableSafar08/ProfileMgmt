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
    public partial class View : Form
    {
        SqlConnection con;
        private SqlCommand cmd1;
        private SqlCommand cmd2;
        private SqlDataAdapter adp1;
        DataSet ds;

        private int PageSize = 5;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0; 
        public View()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel1.Visible = true;
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

           /* txtSid.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();*/
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

        private void View_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

           LoadGrid();
        }

        private void LoadGrid()
        {

            con = new SqlConnection("Data Source=19171r; Integrated Security=true; Initial Catalog=Profile");
            cmd1 = new SqlCommand("Select * from Profile order by Sid", con);
            ds = new DataSet();
            adp1 = new SqlDataAdapter(cmd1);
            adp1.Fill(ds, "Profile");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Profile";

            // WORK IN PAGING FOR DATAGRIDVIEW
            // Get total count of the pages; 
            this.CalculateTotalPages();
            this.dataGridView1.ReadOnly = true;
            // Load the first page of data; 
            this.dataGridView1.DataSource = GetCurrentRecords(1, con);
            /*SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = " SELECT * from Profile";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/
        }

        private DataTable GetCurrentRecords(int page, SqlConnection con)
        {
            DataTable dt = new DataTable();

            if (page == 1)
            {
                cmd2 = new SqlCommand("Select TOP " + PageSize + " * from Profile ORDER BY Sid", con);
            }
            else
            {
                int PreviouspageLimit = (page - 1) * PageSize;

                cmd2 = new SqlCommand("Select TOP " + PageSize +
                    " * from Profile " +
                    "WHERE Sid NOT IN " +
                "(Select TOP " + PreviouspageLimit + " Sid from Profile ORDER BY Sid) ", con); // +
                //"order by customerid", con);
            }
            try
            {
                // con.Open();
                this.adp1.SelectCommand = cmd2;
                this.adp1.Fill(dt);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        private void CalculateTotalPages()
        {
            int rowCount = ds.Tables["Profile"].Rows.Count;
            this.TotalPage = rowCount / PageSize;
            if (rowCount % PageSize > 0) // if remainder is more than  zero 
            {
                this.TotalPage += 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
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
            LoadGrid();
            txtName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu aa = new menu();
            this.Hide();
            aa.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           Report aa = new Report();
            this.Hide();
            aa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFirstPAge_Click(object sender, EventArgs e)
        {

            this.CurrentPageIndex = 1;
            this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
            currInd.Text= CurrentPageIndex.ToString();
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {

            if (this.CurrentPageIndex < this.TotalPage)
            {
                this.CurrentPageIndex++;
                this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con);
            } 
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, con); 
        }
    }
}
