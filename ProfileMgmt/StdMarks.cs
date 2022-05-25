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
    public partial class StdMarks : Form
    {
        public StdMarks()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "insert into Marks(Sid,DBMS,CS,MM,DMS,WEB_TECH,CO,TOTAL_MARKS,OBTAINED_MARKS,PERCENTAGE,Program,RESULT) values(@Sid,@dbms,@cs,@mm,@dms,@web,@co,@tm,@om,@per,@res)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@dbms", txtDbms.Text);
            cmd.Parameters.AddWithValue("@cs", txtCs.Text);
            cmd.Parameters.AddWithValue("@mm", txtMm.Text);
            cmd.Parameters.AddWithValue("@dms", txtDms.Text);
            cmd.Parameters.AddWithValue("@web", txtWeb.Text);
            cmd.Parameters.AddWithValue("@co", txtCo.Text);
            cmd.Parameters.AddWithValue("@tm", txtTot.Text);
            cmd.Parameters.AddWithValue("@om", txtObt.Text);
            cmd.Parameters.AddWithValue("@per", txtPer.Text);
            cmd.Parameters.AddWithValue("@res", txtRes.Text);
            cmd.Parameters.AddWithValue("@Sid", txtSid.Text);
            con.Open();

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                LoadGrid();
                MessageBox.Show(" Created Successfully !! ");
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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


            txtSid.Focus();
        }

        private void txtSid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu aa = new menu();
            this.Hide();
            aa.ShowDialog();
        }

        private void StdMarks_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select *from Profile,Marks where Profile.Sid=Marks.Sid";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
