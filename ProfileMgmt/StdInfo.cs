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
using System.Configuration;

namespace ProfileMgmt
{
    public partial class StdInfo : Form
    {
        public StdInfo()
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
            string StringNumber_Pattern = "^[0-9]*$";

            return new Regex(StringNumber_Pattern, RegexOptions.IgnoreCase);
        }


        private void CreateNew_Load(object sender, EventArgs e)
        {
            cbGender.SelectedIndex = 0;
            cbPro.SelectedIndex = 0;
            cbFac.SelectedIndex = 0;
            cbNat.SelectedIndex = 0;
            LoadGrid();
            panel1.Visible = false;
        }

        private void LoadGrid()
        {
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            string sql = "select * from Profile order by Sid desc";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
             
            //Connection to the DATABASE
            SqlConnection con = new SqlConnection("data source=19171r; integrated security=true; initial catalog=Profile");
            SqlDataAdapter sda = new SqlDataAdapter("Select Sid from Profile where Sid='"+txtSid.Text+"' ", con);
            DataTable dtid = new DataTable();
            sda.Fill(dtid);
            if (dtid.Rows.Count > 0)
            {
                MessageBox.Show("ID Already Exist !!!", ("ID Existing Check"), MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //DATA INSERT INTO THE TABLE PROFILE
                string sql = "insert into Profile(Sid,Name,P_Name,P_Con,Permanent_Address,Correspondance_Address,Phone,Email,Gender,DOB,Batch,Program,Faculty,Semester,SUB1,SUB2,SUB3,SUB4,SUB5,SUB6,TOTAL_MARKS,OBTAINED_MARKS,PERCENTAGE,RESULT) values(@id,@n,@pn,@pc,@padd,@pcor,@ph,@e,@g,@dob,@b,@p,@f,@sem,@dbms,@cs,@mm,@dms,@web,@co,@tm,@om,@per,@res)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@n", txtName.Text);
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
                if ((txtPc.Text == "" ) || (txtPc.Text.Length < 10) || (txtPc.Text.Length > 10))
                {
                    MessageBox.Show("Enter Parent's Phone Number (it Accept 10-Digits Nubers Only).", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("Enter Student's Phone Number (it Accept 10-Digits Nubers Only).", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("Enter Batch (it Accept 4-Digits Nubers Only).", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                else if (txtCs.Text == "")
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
                else if(txtTot.Text == "" || txtObt.Text == "" || txtPer.Text == "" || txtRes.Text == "")
                {
                    MessageBox.Show("Click On 'Calculate' Button, Calculate button not Clicked!!!", ("Invalid"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Data Inserted Succesfully !!!", ("Insert Data"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    con.Close();
            }
         }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //TO CLEAR THE DATA INPUTTED BY THE USER
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
            panel1.Visible = false;

            txtName.Focus();
            btnCreate.Text = "Save ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu aa = new menu();
            this.Hide();
            aa.ShowDialog();
        }

        private void cbNat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {   //Logic for Empty Field Validation

            if (txtDbms.Text == "") //empty Textfield validation
            {
                MessageBox.Show("Please Enter Marks for SUB1 !!!", ("TextBox Validation"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDbms.Focus();
                return;
            }
            else if (txtCs.Text == "")
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

                    panel1.Visible = true;
                }
            }
        }
        private void label25_Click(object sender, EventArgs e)
        {

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

        private void txtPc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtBatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
