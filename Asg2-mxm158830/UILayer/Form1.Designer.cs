namespace Asg2_mxm158830
{
    partial class frmrebateprocessing
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
            this.components = new System.ComponentModel.Container();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.txtboxfname = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errprovidervalidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtboxlname = new System.Windows.Forms.TextBox();
            this.lblmiddleinitial = new System.Windows.Forms.Label();
            this.txtboxmiddleinitial = new System.Windows.Forms.TextBox();
            this.lbladdressline1 = new System.Windows.Forms.Label();
            this.txtboxaddressline1 = new System.Windows.Forms.TextBox();
            this.lbladdressline2 = new System.Windows.Forms.Label();
            this.txtboxaddressline2 = new System.Windows.Forms.TextBox();
            this.lblcity = new System.Windows.Forms.Label();
            this.txtboxcity = new System.Windows.Forms.TextBox();
            this.comboboxstate = new System.Windows.Forms.ComboBox();
            this.lblstate = new System.Windows.Forms.Label();
            this.lblzipcode = new System.Windows.Forms.Label();
            this.txtboxzipcode = new System.Windows.Forms.TextBox();
            this.lbphonenumber = new System.Windows.Forms.Label();
            this.txtboxphonenumber = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.lblproof = new System.Windows.Forms.Label();
            this.comboboxproof = new System.Windows.Forms.ComboBox();
            this.lbldaterecieved = new System.Windows.Forms.Label();
            this.datetimepicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtboxresponses = new System.Windows.Forms.TextBox();
            this.listviewpersons = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnphonenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprovidervalidation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(453, 30);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(60, 13);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First Name:";
            this.lblfirstname.Click += new System.EventHandler(this.lblfirstname_Click);
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(452, 70);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(61, 13);
            this.lbllname.TabIndex = 1;
            this.lbllname.Text = "Last Name:";
            this.lbllname.Click += new System.EventHandler(this.lbllname_Click);
            // 
            // txtboxfname
            // 
            this.txtboxfname.Location = new System.Drawing.Point(546, 27);
            this.txtboxfname.MaxLength = 20;
            this.txtboxfname.Name = "txtboxfname";
            this.txtboxfname.Size = new System.Drawing.Size(105, 20);
            this.txtboxfname.TabIndex = 2;
            this.txtboxfname.TextChanged += new System.EventHandler(this.txtboxfname_TextChanged);
            this.txtboxfname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtboxfname_KeyUp);
            this.txtboxfname.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxfname_Validating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // errprovidervalidation
            // 
            this.errprovidervalidation.ContainerControl = this;
            // 
            // txtboxlname
            // 
            this.txtboxlname.Location = new System.Drawing.Point(546, 66);
            this.txtboxlname.MaxLength = 20;
            this.txtboxlname.Name = "txtboxlname";
            this.txtboxlname.Size = new System.Drawing.Size(105, 20);
            this.txtboxlname.TabIndex = 5;
            this.txtboxlname.TextChanged += new System.EventHandler(this.txtboxlname_TextChanged);
            this.txtboxlname.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxlname_Validating);
            // 
            // lblmiddleinitial
            // 
            this.lblmiddleinitial.AutoSize = true;
            this.lblmiddleinitial.Location = new System.Drawing.Point(448, 110);
            this.lblmiddleinitial.Name = "lblmiddleinitial";
            this.lblmiddleinitial.Size = new System.Drawing.Size(65, 13);
            this.lblmiddleinitial.TabIndex = 6;
            this.lblmiddleinitial.Text = "Middle Initial";
            this.lblmiddleinitial.Click += new System.EventHandler(this.lblmiddleinitial_Click);
            // 
            // txtboxmiddleinitial
            // 
            this.txtboxmiddleinitial.BackColor = System.Drawing.Color.Yellow;
            this.txtboxmiddleinitial.Location = new System.Drawing.Point(546, 105);
            this.txtboxmiddleinitial.MaxLength = 1;
            this.txtboxmiddleinitial.Name = "txtboxmiddleinitial";
            this.txtboxmiddleinitial.Size = new System.Drawing.Size(20, 20);
            this.txtboxmiddleinitial.TabIndex = 7;
            this.txtboxmiddleinitial.TextChanged += new System.EventHandler(this.txtboxmiddleinitial_TextChanged);
            // 
            // lbladdressline1
            // 
            this.lbladdressline1.AutoSize = true;
            this.lbladdressline1.Location = new System.Drawing.Point(436, 150);
            this.lbladdressline1.Name = "lbladdressline1";
            this.lbladdressline1.Size = new System.Drawing.Size(77, 13);
            this.lbladdressline1.TabIndex = 8;
            this.lbladdressline1.Text = "Address Line 1";
            this.lbladdressline1.Click += new System.EventHandler(this.lbladdressline1_Click);
            // 
            // txtboxaddressline1
            // 
            this.txtboxaddressline1.Location = new System.Drawing.Point(546, 144);
            this.txtboxaddressline1.MaxLength = 35;
            this.txtboxaddressline1.Name = "txtboxaddressline1";
            this.txtboxaddressline1.Size = new System.Drawing.Size(217, 20);
            this.txtboxaddressline1.TabIndex = 9;
            this.txtboxaddressline1.TextChanged += new System.EventHandler(this.txtboxaddressline1_TextChanged);
            this.txtboxaddressline1.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxaddressline1_Validating);
            // 
            // lbladdressline2
            // 
            this.lbladdressline2.AutoSize = true;
            this.lbladdressline2.Location = new System.Drawing.Point(436, 190);
            this.lbladdressline2.Name = "lbladdressline2";
            this.lbladdressline2.Size = new System.Drawing.Size(77, 13);
            this.lbladdressline2.TabIndex = 10;
            this.lbladdressline2.Text = "Address Line 2";
            this.lbladdressline2.Click += new System.EventHandler(this.lbladdressline2_Click);
            // 
            // txtboxaddressline2
            // 
            this.txtboxaddressline2.BackColor = System.Drawing.Color.Yellow;
            this.txtboxaddressline2.Location = new System.Drawing.Point(546, 183);
            this.txtboxaddressline2.MaxLength = 35;
            this.txtboxaddressline2.Name = "txtboxaddressline2";
            this.txtboxaddressline2.Size = new System.Drawing.Size(217, 20);
            this.txtboxaddressline2.TabIndex = 11;
            this.txtboxaddressline2.TextChanged += new System.EventHandler(this.txtboxaddressline2_TextChanged);
            this.txtboxaddressline2.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxaddressline2_Validating);
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(489, 230);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(24, 13);
            this.lblcity.TabIndex = 12;
            this.lblcity.Text = "City";
            this.lblcity.Click += new System.EventHandler(this.lblcity_Click);
            // 
            // txtboxcity
            // 
            this.txtboxcity.Location = new System.Drawing.Point(546, 225);
            this.txtboxcity.MaxLength = 25;
            this.txtboxcity.Name = "txtboxcity";
            this.txtboxcity.Size = new System.Drawing.Size(115, 20);
            this.txtboxcity.TabIndex = 13;
            this.txtboxcity.TextChanged += new System.EventHandler(this.txtboxcity_TextChanged);
            this.txtboxcity.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxcity_Validating);
            // 
            // comboboxstate
            // 
            this.comboboxstate.AutoCompleteCustomSource.AddRange(new string[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA\t",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MH",
            "MA",
            "MI",
            "FM",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PW",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "VI",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboboxstate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxstate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboboxstate.FormattingEnabled = true;
            this.comboboxstate.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA\t",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MH",
            "MA",
            "MI",
            "FM",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PW",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "VI",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboboxstate.Location = new System.Drawing.Point(546, 265);
            this.comboboxstate.MaxLength = 2;
            this.comboboxstate.Name = "comboboxstate";
            this.comboboxstate.Size = new System.Drawing.Size(55, 21);
            this.comboboxstate.TabIndex = 14;
            this.comboboxstate.TextUpdate += new System.EventHandler(this.comboboxstate_TextUpdate);
            this.comboboxstate.TextChanged += new System.EventHandler(this.comboboxstate_TextChanged);
            this.comboboxstate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboboxstate_KeyDown);
            this.comboboxstate.Validating += new System.ComponentModel.CancelEventHandler(this.comboboxstate_Validating);
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(481, 270);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(32, 13);
            this.lblstate.TabIndex = 15;
            this.lblstate.Text = "State";
            this.lblstate.Click += new System.EventHandler(this.lblstate_Click);
            // 
            // lblzipcode
            // 
            this.lblzipcode.AutoSize = true;
            this.lblzipcode.Location = new System.Drawing.Point(463, 310);
            this.lblzipcode.Name = "lblzipcode";
            this.lblzipcode.Size = new System.Drawing.Size(50, 13);
            this.lblzipcode.TabIndex = 16;
            this.lblzipcode.Text = "Zip Code";
            this.lblzipcode.Click += new System.EventHandler(this.lblzipcode_Click);
            // 
            // txtboxzipcode
            // 
            this.txtboxzipcode.Location = new System.Drawing.Point(546, 305);
            this.txtboxzipcode.MaxLength = 9;
            this.txtboxzipcode.Name = "txtboxzipcode";
            this.txtboxzipcode.Size = new System.Drawing.Size(62, 20);
            this.txtboxzipcode.TabIndex = 17;
            this.txtboxzipcode.TextChanged += new System.EventHandler(this.txtboxzipcode_TextChanged);
            this.txtboxzipcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxzipcode_Validating);
            // 
            // lbphonenumber
            // 
            this.lbphonenumber.AutoSize = true;
            this.lbphonenumber.Location = new System.Drawing.Point(437, 350);
            this.lbphonenumber.Name = "lbphonenumber";
            this.lbphonenumber.Size = new System.Drawing.Size(76, 13);
            this.lbphonenumber.TabIndex = 18;
            this.lbphonenumber.Text = "Phone number";
            this.lbphonenumber.Click += new System.EventHandler(this.lbphonenumber_Click);
            // 
            // txtboxphonenumber
            // 
            this.txtboxphonenumber.Location = new System.Drawing.Point(546, 346);
            this.txtboxphonenumber.MaxLength = 21;
            this.txtboxphonenumber.Name = "txtboxphonenumber";
            this.txtboxphonenumber.Size = new System.Drawing.Size(107, 20);
            this.txtboxphonenumber.TabIndex = 19;
            this.txtboxphonenumber.TextChanged += new System.EventHandler(this.txtboxphonenumber_TextChanged);
            this.txtboxphonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxphonenumber_Validating);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(469, 390);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(44, 13);
            this.lblemail.TabIndex = 20;
            this.lblemail.Text = "Email Id";
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(546, 386);
            this.txtboxemail.MaxLength = 60;
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(292, 20);
            this.txtboxemail.TabIndex = 21;
            this.txtboxemail.TextChanged += new System.EventHandler(this.txtboxemail_TextChanged);
            this.txtboxemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxemail_Validating);
            // 
            // lblproof
            // 
            this.lblproof.AutoSize = true;
            this.lblproof.Location = new System.Drawing.Point(330, 430);
            this.lblproof.Name = "lblproof";
            this.lblproof.Size = new System.Drawing.Size(185, 13);
            this.lblproof.TabIndex = 22;
            this.lblproof.Text = "Proof of purchase attached (Yes/No) ";
            // 
            // comboboxproof
            // 
            this.comboboxproof.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboboxproof.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.comboboxproof.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboboxproof.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxproof.FormattingEnabled = true;
            this.comboboxproof.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboboxproof.Location = new System.Drawing.Point(546, 427);
            this.comboboxproof.Name = "comboboxproof";
            this.comboboxproof.Size = new System.Drawing.Size(70, 21);
            this.comboboxproof.TabIndex = 23;
            this.comboboxproof.SelectedIndexChanged += new System.EventHandler(this.comboboxproof_SelectedIndexChanged);
            this.comboboxproof.TextUpdate += new System.EventHandler(this.comboboxproof_TextUpdate);
            this.comboboxproof.TextChanged += new System.EventHandler(this.comboboxproof_TextChanged);
            this.comboboxproof.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboboxproof_KeyDown);
            this.comboboxproof.Validating += new System.ComponentModel.CancelEventHandler(this.comboboxproof_Validating);
            // 
            // lbldaterecieved
            // 
            this.lbldaterecieved.AutoSize = true;
            this.lbldaterecieved.Location = new System.Drawing.Point(434, 468);
            this.lbldaterecieved.Name = "lbldaterecieved";
            this.lbldaterecieved.Size = new System.Drawing.Size(79, 13);
            this.lbldaterecieved.TabIndex = 24;
            this.lbldaterecieved.Text = "Date Recieved";
            // 
            // datetimepicker1
            // 
            this.datetimepicker1.Location = new System.Drawing.Point(546, 464);
            this.datetimepicker1.Name = "datetimepicker1";
            this.datetimepicker1.Size = new System.Drawing.Size(200, 20);
            this.datetimepicker1.TabIndex = 25;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(446, 538);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(595, 538);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 27;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(744, 538);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtboxresponses
            // 
            this.txtboxresponses.Location = new System.Drawing.Point(440, 614);
            this.txtboxresponses.Multiline = true;
            this.txtboxresponses.Name = "txtboxresponses";
            this.txtboxresponses.Size = new System.Drawing.Size(398, 51);
            this.txtboxresponses.TabIndex = 29;
            this.txtboxresponses.Text = "Response Messages:";
            // 
            // listviewpersons
            // 
            this.listviewpersons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnphonenum});
            this.listviewpersons.FullRowSelect = true;
            this.listviewpersons.Location = new System.Drawing.Point(12, 12);
            this.listviewpersons.Name = "listviewpersons";
            this.listviewpersons.Size = new System.Drawing.Size(312, 653);
            this.listviewpersons.TabIndex = 30;
            this.listviewpersons.UseCompatibleStateImageBehavior = false;
            this.listviewpersons.View = System.Windows.Forms.View.Details;
            this.listviewpersons.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listviewpersons_ColumnClick);
            this.listviewpersons.SelectedIndexChanged += new System.EventHandler(this.listviewpersons_SelectedIndexChanged);
            this.listviewpersons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewpersons_MouseClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Full Name";
            this.columnName.Width = 165;
            // 
            // columnphonenum
            // 
            this.columnphonenum.Text = "Phone Number";
            this.columnphonenum.Width = 141;
            // 
            // frmrebateprocessing
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 699);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.listviewpersons);
            this.Controls.Add(this.txtboxresponses);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.datetimepicker1);
            this.Controls.Add(this.lbldaterecieved);
            this.Controls.Add(this.comboboxproof);
            this.Controls.Add(this.lblproof);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtboxphonenumber);
            this.Controls.Add(this.lbphonenumber);
            this.Controls.Add(this.txtboxzipcode);
            this.Controls.Add(this.lblzipcode);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.comboboxstate);
            this.Controls.Add(this.txtboxcity);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.txtboxaddressline2);
            this.Controls.Add(this.lbladdressline2);
            this.Controls.Add(this.txtboxaddressline1);
            this.Controls.Add(this.lbladdressline1);
            this.Controls.Add(this.txtboxmiddleinitial);
            this.Controls.Add(this.lblmiddleinitial);
            this.Controls.Add(this.txtboxlname);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtboxfname);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfirstname);
            this.Name = "frmrebateprocessing";
            this.Text = "Rebate Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprovidervalidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.TextBox txtboxfname;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ErrorProvider errprovidervalidation;
        private System.Windows.Forms.TextBox txtboxlname;
        private System.Windows.Forms.Label lblmiddleinitial;
        private System.Windows.Forms.TextBox txtboxmiddleinitial;
        private System.Windows.Forms.Label lbladdressline1;
        public System.Windows.Forms.TextBox txtboxaddressline1;
        private System.Windows.Forms.TextBox txtboxaddressline2;
        private System.Windows.Forms.Label lbladdressline2;
        private System.Windows.Forms.TextBox txtboxcity;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblstate;
        public System.Windows.Forms.ComboBox comboboxstate;
        private System.Windows.Forms.TextBox txtboxzipcode;
        private System.Windows.Forms.Label lblzipcode;
        private System.Windows.Forms.Label lbphonenumber;
        private System.Windows.Forms.TextBox txtboxphonenumber;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.Label lblproof;
        private System.Windows.Forms.ComboBox comboboxproof;
        private System.Windows.Forms.DateTimePicker datetimepicker1;
        private System.Windows.Forms.Label lbldaterecieved;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtboxresponses;
        private System.Windows.Forms.ListView listviewpersons;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnphonenum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

