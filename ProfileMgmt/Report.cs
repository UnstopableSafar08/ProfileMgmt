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
using System.Drawing.Printing;

namespace ProfileMgmt
{
    public partial class Report : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog(); //init
        PrintDocument prntdoc = new PrintDocument();
        public Report()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            l11.Visible = false;
            l12.Visible = false;
            l13.Visible = false;
            l14.Visible = false;
            l15.Visible = false;
            l16.Visible = false;
            l17.Visible = false;

           // LoadGrid();

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
        private void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {

        }

      private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {


            l1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            l2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            l3.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            l4.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            l5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            l6.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            l7.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            l8.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            l9.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            l10.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            l11.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            l12.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            l13.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            l14.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            l15.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
            l16.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
            l17.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();


            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;
            l5.Visible = true;
            l6.Visible = true;
            l7.Visible = true;
            l8.Visible = true;
            l9.Visible = true;
            l10.Visible = true;
            l11.Visible = true;
            l12.Visible = true;
            l13.Visible = true;
            l14.Visible = true;
            l15.Visible = true;
            l16.Visible = true;
            l17.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu aa = new menu();
            this.Hide();
            aa.ShowDialog();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchId.Text = "";
            txtSearchId.Focus();
            l1.Visible = false;
            l2.Visible = false;
            l3.Visible = false;
            l4.Visible = false;
            l5.Visible = false;
            l6.Visible = false;
            l7.Visible = false;
            l8.Visible = false;
            l9.Visible = false;
            l10.Visible = false;
            l11.Visible = false;
            l12.Visible = false;
            l13.Visible = false;
            l14.Visible = false;
            l15.Visible = false;
            l16.Visible = false;
            l17.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Print(this.gbPrint); //call method
        }
        public void Print(GroupBox gb1)  //print() defination
        {
            PrinterSettings ps = new PrinterSettings();
            gbPrint = gb1;
            getprintarea(gb1);
            prntprvw.Document = prntdoc;
            prntdoc.PrintPage += new PrintPageEventHandler(prntdoc_printpage);
            prntprvw.ShowDialog();
        }
        public void prntdoc_printpage(object sender, PrintPageEventArgs e) //groupbox print()
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 10) - (this.gbPrint.Width / 10), this.gbPrint.Location.Y);
        }
        Bitmap memoryimg;
        public void getprintarea(GroupBox gb1)
        {
            memoryimg = new Bitmap(gb1.Width, gb1.Height);
            gb1.DrawToBitmap(memoryimg, new Rectangle(0, 0, gb1.Width, gb1.Height));
        }
    }
}
