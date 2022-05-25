namespace ProfileMgmt
{
    partial class Student_Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPc = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNat = new System.Windows.Forms.ComboBox();
            this.cbFac = new System.Windows.Forms.ComboBox();
            this.cbPro = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtPadd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPcor = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPh = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearchId = new System.Windows.Forms.Button();
            this.btnSearchSem = new System.Windows.Forms.Button();
            this.txtSearchSem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Red;
            this.btnCreate.Font = new System.Drawing.Font("Scramble", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(96, 482);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(162, 37);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "CREATE NEW";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Scramble", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(264, 481);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Scramble", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(406, 482);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 37);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Bisque;
            this.txtSearch.Location = new System.Drawing.Point(765, 330);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 525);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1316, 200);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(622, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 22);
            this.label15.TabIndex = 20;
            this.label15.Text = " SEARCH BY NAME";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.Font = new System.Drawing.Font("Scramble", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(928, 320);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 37);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Swordfish", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SpringGreen;
            this.label16.Location = new System.Drawing.Point(244, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(474, 39);
            this.label16.TabIndex = 4;
            this.label16.Text = "STUDENT PROFILE RECORDS";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtSid);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtPc);
            this.groupBox1.Controls.Add(this.txtPname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbNat);
            this.groupBox1.Controls.Add(this.cbFac);
            this.groupBox1.Controls.Add(this.cbPro);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.txtPadd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtBatch);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtPcor);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPh);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 440);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student_Info";
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(232, 230);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(97, 20);
            this.txtDate.TabIndex = 53;
            this.txtDate.Value = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            // 
            // txtSid
            // 
            this.txtSid.BackColor = System.Drawing.Color.Bisque;
            this.txtSid.Location = new System.Drawing.Point(229, 363);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(153, 20);
            this.txtSid.TabIndex = 52;
            this.txtSid.TextChanged += new System.EventHandler(this.txtSid_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(189, 363);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 22);
            this.label17.TabIndex = 51;
            this.label17.Text = "Sid";
            // 
            // txtPc
            // 
            this.txtPc.BackColor = System.Drawing.Color.Bisque;
            this.txtPc.Location = new System.Drawing.Point(232, 73);
            this.txtPc.Name = "txtPc";
            this.txtPc.Size = new System.Drawing.Size(259, 20);
            this.txtPc.TabIndex = 50;
            // 
            // txtPname
            // 
            this.txtPname.BackColor = System.Drawing.Color.Bisque;
            this.txtPname.Location = new System.Drawing.Point(232, 47);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(259, 20);
            this.txtPname.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "PARENT\'S NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "PARENT\'S CONTACT NO";
            // 
            // cbNat
            // 
            this.cbNat.BackColor = System.Drawing.Color.Bisque;
            this.cbNat.FormattingEnabled = true;
            this.cbNat.Items.AddRange(new object[] {
            "Select Semester",
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII"});
            this.cbNat.Location = new System.Drawing.Point(232, 336);
            this.cbNat.Name = "cbNat";
            this.cbNat.Size = new System.Drawing.Size(150, 21);
            this.cbNat.TabIndex = 44;
            this.cbNat.Text = "Select Semester";
            // 
            // cbFac
            // 
            this.cbFac.BackColor = System.Drawing.Color.Bisque;
            this.cbFac.FormattingEnabled = true;
            this.cbFac.Items.AddRange(new object[] {
            "Select Faculty",
            "SCI AND TECH",
            "MANAGEMENT",
            "HEALTH",
            "HUMANITIES"});
            this.cbFac.Location = new System.Drawing.Point(232, 309);
            this.cbFac.Name = "cbFac";
            this.cbFac.Size = new System.Drawing.Size(150, 21);
            this.cbFac.TabIndex = 43;
            this.cbFac.Text = "Select Faculty";
            // 
            // cbPro
            // 
            this.cbPro.BackColor = System.Drawing.Color.Bisque;
            this.cbPro.FormattingEnabled = true;
            this.cbPro.Items.AddRange(new object[] {
            "Select Program",
            "BIT",
            "BCA",
            "BE",
            "BE COMM",
            "BBA"});
            this.cbPro.Location = new System.Drawing.Point(232, 282);
            this.cbPro.Name = "cbPro";
            this.cbPro.Size = new System.Drawing.Size(150, 21);
            this.cbPro.TabIndex = 42;
            this.cbPro.Text = "Select Program";
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Bisque;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Select Gender",
            "MALE",
            "FEMALE"});
            this.cbGender.Location = new System.Drawing.Point(232, 203);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(97, 21);
            this.cbGender.TabIndex = 41;
            this.cbGender.Text = "Select Gender";
            // 
            // txtPadd
            // 
            this.txtPadd.BackColor = System.Drawing.Color.Bisque;
            this.txtPadd.Location = new System.Drawing.Point(232, 99);
            this.txtPadd.Name = "txtPadd";
            this.txtPadd.Size = new System.Drawing.Size(259, 20);
            this.txtPadd.TabIndex = 39;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Bisque;
            this.txtName.Location = new System.Drawing.Point(232, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 20);
            this.txtName.TabIndex = 35;
            // 
            // txtBatch
            // 
            this.txtBatch.BackColor = System.Drawing.Color.Bisque;
            this.txtBatch.Location = new System.Drawing.Point(232, 256);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(150, 20);
            this.txtBatch.TabIndex = 40;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Bisque;
            this.txtPhone.Location = new System.Drawing.Point(232, 151);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(259, 20);
            this.txtPhone.TabIndex = 38;
            // 
            // txtPcor
            // 
            this.txtPcor.BackColor = System.Drawing.Color.Bisque;
            this.txtPcor.Location = new System.Drawing.Point(232, 125);
            this.txtPcor.Name = "txtPcor";
            this.txtPcor.Size = new System.Drawing.Size(259, 20);
            this.txtPcor.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Bisque;
            this.txtEmail.Location = new System.Drawing.Point(232, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 20);
            this.txtEmail.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "STUDENT NAME";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(221, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(171, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "BATCH";
            // 
            // txtPh
            // 
            this.txtPh.AutoSize = true;
            this.txtPh.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPh.Location = new System.Drawing.Point(167, 151);
            this.txtPh.Name = "txtPh";
            this.txtPh.Size = new System.Drawing.Size(59, 22);
            this.txtPh.TabIndex = 30;
            this.txtPh.Text = "PHONE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(157, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 22);
            this.label12.TabIndex = 29;
            this.label12.Text = "FACULTY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "PERMANENT ADDRESS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "SEMESTER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "PROGRAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(191, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "CORRESPONDANCE ADDRESS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(646, 377);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 22);
            this.label18.TabIndex = 20;
            this.label18.Text = " SEARCH BY ID";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(589, 419);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 22);
            this.label19.TabIndex = 20;
            this.label19.Text = " SEARCH BY SEMESTER";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(765, 377);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(156, 20);
            this.txtSearchId.TabIndex = 23;
            this.txtSearchId.TextChanged += new System.EventHandler(this.txtSearchId_TextChanged);
            // 
            // btnSearchId
            // 
            this.btnSearchId.Location = new System.Drawing.Point(946, 376);
            this.btnSearchId.Name = "btnSearchId";
            this.btnSearchId.Size = new System.Drawing.Size(75, 23);
            this.btnSearchId.TabIndex = 24;
            this.btnSearchId.Text = "search by id";
            this.btnSearchId.UseVisualStyleBackColor = true;
            this.btnSearchId.Click += new System.EventHandler(this.btnSearchId_Click);
            // 
            // btnSearchSem
            // 
            this.btnSearchSem.Location = new System.Drawing.Point(955, 432);
            this.btnSearchSem.Name = "btnSearchSem";
            this.btnSearchSem.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSem.TabIndex = 25;
            this.btnSearchSem.Text = "SEARCH BY SEM";
            this.btnSearchSem.UseVisualStyleBackColor = true;
            this.btnSearchSem.Click += new System.EventHandler(this.btnSearchSem_Click);
            // 
            // txtSearchSem
            // 
            this.txtSearchSem.Location = new System.Drawing.Point(808, 432);
            this.txtSearchSem.Name = "txtSearchSem";
            this.txtSearchSem.Size = new System.Drawing.Size(100, 20);
            this.txtSearchSem.TabIndex = 26;
            this.txtSearchSem.TextChanged += new System.EventHandler(this.txtSearchSem_TextChanged);
            // 
            // Student_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.txtSearchSem);
            this.Controls.Add(this.btnSearchSem);
            this.Controls.Add(this.btnSearchId);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label16);
            this.Name = "Student_Data";
            this.Text = "Student_Data";
            this.Load += new System.EventHandler(this.Student_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPc;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNat;
        private System.Windows.Forms.ComboBox cbFac;
        private System.Windows.Forms.ComboBox cbPro;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox txtPadd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPcor;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtPh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button btnSearchId;
        private System.Windows.Forms.Button btnSearchSem;
        private System.Windows.Forms.TextBox txtSearchSem;
    }
}