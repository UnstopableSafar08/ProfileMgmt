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
using System.Text.RegularExpressions;

namespace ProfileMgmt
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        //initialize the validating method
        static Regex Valid_Name = StringOnly();
        static Regex Valid_Contact = NumbersOnly();
        /* static Regex Valid_Password = ValidPassword();*/
        static Regex Valid_Email = Email_Address();



        //Method for validating email address
        private static Regex Email_Address()
        {
            string Email_Pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(Email_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for string validation only
        private static Regex StringOnly()
        {
            string StringAndNumber_Pattern = "^[a-zA-Z]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        //Method for numbers validation only
        private static Regex NumbersOnly()
        {
            string StringAndNumber_Pattern = "^[0-9]*$";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
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
            LoadGrid();
            txtName.Focus();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu aa = new menu();
            this.Hide();
            aa.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure, You want to Update Record ???", ("Update Button click Message"), MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            //Connection to the DATABAS
                //DATA INSERT INTO THE TABLE PROFILE
                SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
                string sql = "update Profile set Name=@name,P_Name=@pn,P_Con=@pc,Permanent_Address=@padd,Correspondance_Address=@pcor,Phone=@ph,Email=@e,Gender=@g,DOB=@dob,Batch=@b,Program=@p,Faculty=@f,Semester=@sem,SUB1=@dbms,SUB2=@cs,SUB3=@mm,SUB4=@dms,SUB5=@web,SUB6=@co,TOTAL_MARKS=@tm,OBTAINED_MARKS=@om,PERCENTAGE=@per,RESULT=@res WHERE Sid=@id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                if (Valid_Name.IsMatch(txtName.Text) != true)
                {
                    MessageBox.Show("Student Name accepts only alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtName.Focus();
                    return;
                }

                cmd.Parameters.AddWithValue("@pn", txtPname.Text);
                if (Valid_Name.IsMatch(txtPname.Text) != true)
                {
                    MessageBox.Show("Parent Name accepts only alphabetical characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPname.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@pc", txtPc.Text);
                if ((txtPc.Text == "") || (txtPc.Text.Length < 10) || (txtPc.Text.Length > 10))
                {
                    MessageBox.Show("Enter Parent's Phone Number (it Accept Nubers Only).", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPc.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@padd", txtPadd.Text);
                if (txtPadd.Text == "")
                {
                    MessageBox.Show("Permanent Address cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPadd.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@pcor", txtPcor.Text);
                if (txtPcor.Text == "")
                {
                    MessageBox.Show("Correspondance Address cannot be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPcor.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                if ((txtPhone.Text == "") || (txtPhone.Text.Length < 10) || (txtPhone.Text.Length > 10))
                {
                    MessageBox.Show("Enter Student's Phone Number (it Accept Nubers Only).", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPhone.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@e", txtEmail.Text);
                //for Email Address 
                if (Valid_Email.IsMatch(txtEmail.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                    return;
                }

                //combobox validation
                if (this.cbGender.Text.ToString() == "Select Gender") //item unselected ,comboBox validation
                {
                    MessageBox.Show("Please select GENDER !!!", ("ComboBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbGender.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@g", cbGender.Text);
                cmd.Parameters.AddWithValue("@dob", this.txtDate.Text);
                cmd.Parameters.AddWithValue("@b", txtBatch.Text);
                if ((txtBatch.Text == "") || (txtBatch.Text.Length < 4) || (txtBatch.Text.Length > 4))
                {
                    MessageBox.Show("Enter Batch (it Accept Nubers Only).", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBatch.Focus();
                    return;
                }

                if (this.cbPro.Text.ToString() == "Select Program") //item unselected ,comboBox validation
                {
                    MessageBox.Show("Please select PROGRAM !!!", ("ComboBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbPro.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@p", cbPro.Text);

                if (this.cbFac.Text.ToString() == "Select Faculty") //item unselected ,comboBox validation
                {
                    MessageBox.Show("Please select FACULTY !!!", ("ComboBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbFac.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@f", cbFac.Text);

                if (this.cbNat.Text.ToString() == "Select Semester") //item unselected ,comboBox validation
                {
                    MessageBox.Show("Please select SEMESTER !!!", ("ComboBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbNat.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@sem", cbNat.Text); //NAT = SEMESTER

                if (txtSid.Text == "") //item unselected ,comboBox validation
                {
                    MessageBox.Show("Please Enter Student ID !!!", ("Invalid"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSid.Focus();
                    return;
                }
                cmd.Parameters.AddWithValue("@id", txtSid.Text);


             if (txtDbms.Text == "") //empty Textfield validation
            {
                MessageBox.Show("Please Enter Marks for SUB1 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDbms.Focus();
                return;
            }
            else if(txtCs.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB2 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCs.Focus();
                return;
            }
            else if (txtMm.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB3 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMm.Focus();
                return;
            }
            else if (txtDms.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB4 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDms.Focus();
                return;
            }
            else if (txtWeb.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB5 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeb.Focus();
                return;
            }
            else if (txtCo.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB6 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCo.Focus();
                return;
            }  
             else 
             {
                    //DATA INSERT INTO THE TABLE MARKS


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

                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        LoadGrid();
                        MessageBox.Show("Data Updated Succesfully !!!", ("Updating Data"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    con.Close();
                } 
        }
        private void Update_Load(object sender, EventArgs e)
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
            string sql = " SELECT * from Profile";
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

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            DataTable dt = GetNameByStudentId(txtSearchId.Text);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Record Was Found !", ("Search Error"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchId.Text = "";
                txtSearchId.Focus();
            }
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void txtPc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
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

        private void txtDbms_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCs_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtMm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDms_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtWeb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTot_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtObt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtDbms.Text == "") //empty Textfield validation
            {
                MessageBox.Show("Please Enter Marks for SUB1 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDbms.Focus();
                return;
            }
            else if(txtCs.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB2 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCs.Focus();
                return;
            }
            else if (txtMm.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB3 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMm.Focus();
                return;
            }
            else if (txtDms.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB4 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDms.Focus();
                return;
            }
            else if (txtWeb.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB5 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeb.Focus();
                return;
            }
            else if (txtCo.Text == "")
            {
                MessageBox.Show("Please Enter Marks for SUB6 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCo.Focus();
                return;
            }
            else
            {
                float sub1, sub2, sub3, sub4, sub5, sub6, tot = 600;
                float obt, per;
                sub1 = float.Parse(txtDbms.Text);
                sub2 = float.Parse(txtCs.Text);
                sub3 = float.Parse(txtMm.Text);
                sub4 = float.Parse(txtDms.Text);
                sub5 = float.Parse(txtWeb.Text);
                sub6 = float.Parse(txtCo.Text);

                obt = sub1 + sub2 + sub3 + sub4 + sub5 + sub6;
                per = (obt / 6);

                txtTot.Text = tot.ToString();
                txtObt.Text = obt.ToString();
                txtPer.Text = per.ToString();

                //Logic for Marks validation
                if (sub1 > 100 || sub2 > 100 || sub3 > 100 || sub4 > 100 || sub5 > 100 || sub6 > 100)
                {
                    MessageBox.Show("Please Enter Marks between 1-100 !!!", ("Marks Value Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //Logic for Result 
                    if (sub1 > 31 && sub2 > 31 && sub3 > 31 && sub4 > 31 && sub5 > 31 && sub6 > 31)
                    {
                        txtRes.Text = "PASSED";
                    }
                    else
                        txtRes.Text = "FAILED";

                   // panel1.Visible = true;
                }
            }
        }
    }
 }

