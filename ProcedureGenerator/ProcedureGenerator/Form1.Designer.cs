namespace ProcedureGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDataBasrName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTableNAme = new System.Windows.Forms.ComboBox();
            this.BtnGenrateProcedure = new System.Windows.Forms.Button();
            this.tbxProcedure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxProcedureName = new System.Windows.Forms.TextBox();
            this.rdoSql2000 = new System.Windows.Forms.RadioButton();
            this.rdosql2005 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.chkWAuth = new System.Windows.Forms.CheckBox();
            this.btnGNForm = new System.Windows.Forms.Button();
            this.GenerateProcedure = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFormName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GnForm = new System.Windows.Forms.Button();
            this.GVFormGenration = new System.Windows.Forms.DataGridView();
            this.fields = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            this.GenerateProcedure.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVFormGenration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQlServerName";
            // 
            // tbxServerName
            // 
            this.tbxServerName.Location = new System.Drawing.Point(96, 62);
            this.tbxServerName.Name = "tbxServerName";
            this.tbxServerName.Size = new System.Drawing.Size(182, 20);
            this.tbxServerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database Name";
            // 
            // tbxDataBasrName
            // 
            this.tbxDataBasrName.Location = new System.Drawing.Point(96, 92);
            this.tbxDataBasrName.Name = "tbxDataBasrName";
            this.tbxDataBasrName.Size = new System.Drawing.Size(178, 20);
            this.tbxDataBasrName.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(47, 212);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(147, 24);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TableName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboTableNAme
            // 
            this.cboTableNAme.FormattingEnabled = true;
            this.cboTableNAme.Location = new System.Drawing.Point(89, 256);
            this.cboTableNAme.Name = "cboTableNAme";
            this.cboTableNAme.Size = new System.Drawing.Size(157, 21);
            this.cboTableNAme.TabIndex = 6;
            this.cboTableNAme.SelectedIndexChanged += new System.EventHandler(this.cboTableNAme_SelectedIndexChanged);
            // 
            // BtnGenrateProcedure
            // 
            this.BtnGenrateProcedure.Location = new System.Drawing.Point(9, 44);
            this.BtnGenrateProcedure.Name = "BtnGenrateProcedure";
            this.BtnGenrateProcedure.Size = new System.Drawing.Size(144, 23);
            this.BtnGenrateProcedure.TabIndex = 7;
            this.BtnGenrateProcedure.Text = "Generate Insert Procedure";
            this.BtnGenrateProcedure.UseVisualStyleBackColor = true;
            this.BtnGenrateProcedure.Click += new System.EventHandler(this.BtnGenrateProcedure_Click);
            // 
            // tbxProcedure
            // 
            this.tbxProcedure.Location = new System.Drawing.Point(12, 83);
            this.tbxProcedure.Multiline = true;
            this.tbxProcedure.Name = "tbxProcedure";
            this.tbxProcedure.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxProcedure.Size = new System.Drawing.Size(351, 391);
            this.tbxProcedure.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Procedure Name";
            // 
            // tbxProcedureName
            // 
            this.tbxProcedureName.Location = new System.Drawing.Point(99, 19);
            this.tbxProcedureName.Name = "tbxProcedureName";
            this.tbxProcedureName.Size = new System.Drawing.Size(264, 20);
            this.tbxProcedureName.TabIndex = 10;
            // 
            // rdoSql2000
            // 
            this.rdoSql2000.AutoSize = true;
            this.rdoSql2000.Location = new System.Drawing.Point(6, 23);
            this.rdoSql2000.Name = "rdoSql2000";
            this.rdoSql2000.Size = new System.Drawing.Size(70, 17);
            this.rdoSql2000.TabIndex = 11;
            this.rdoSql2000.TabStop = true;
            this.rdoSql2000.Text = "SQL2000";
            this.rdoSql2000.UseVisualStyleBackColor = true;
            // 
            // rdosql2005
            // 
            this.rdosql2005.AutoSize = true;
            this.rdosql2005.Location = new System.Drawing.Point(113, 23);
            this.rdosql2005.Name = "rdosql2005";
            this.rdosql2005.Size = new System.Drawing.Size(70, 17);
            this.rdosql2005.TabIndex = 12;
            this.rdosql2005.TabStop = true;
            this.rdosql2005.Text = "SQL2005";
            this.rdosql2005.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdosql2005);
            this.groupBox1.Controls.Add(this.rdoSql2000);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 44);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "UserName";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(95, 131);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(140, 20);
            this.tbxUserName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(96, 159);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(144, 20);
            this.tbxPassword.TabIndex = 17;
            // 
            // chkWAuth
            // 
            this.chkWAuth.AutoSize = true;
            this.chkWAuth.Location = new System.Drawing.Point(99, 189);
            this.chkWAuth.Name = "chkWAuth";
            this.chkWAuth.Size = new System.Drawing.Size(136, 17);
            this.chkWAuth.TabIndex = 18;
            this.chkWAuth.Text = "Window Authentication";
            this.chkWAuth.UseVisualStyleBackColor = true;
            this.chkWAuth.CheckedChanged += new System.EventHandler(this.chkWAuth_CheckedChanged);
            // 
            // btnGNForm
            // 
            this.btnGNForm.Location = new System.Drawing.Point(189, 45);
            this.btnGNForm.Name = "btnGNForm";
            this.btnGNForm.Size = new System.Drawing.Size(110, 23);
            this.btnGNForm.TabIndex = 19;
            this.btnGNForm.Text = "GenrateForm";
            this.btnGNForm.UseVisualStyleBackColor = true;
            this.btnGNForm.Click += new System.EventHandler(this.btnGNForm_Click);
            // 
            // GenerateProcedure
            // 
            this.GenerateProcedure.Controls.Add(this.tabPage1);
            this.GenerateProcedure.Controls.Add(this.tabPage2);
            this.GenerateProcedure.Location = new System.Drawing.Point(319, 25);
            this.GenerateProcedure.Name = "GenerateProcedure";
            this.GenerateProcedure.SelectedIndex = 0;
            this.GenerateProcedure.Size = new System.Drawing.Size(414, 523);
            this.GenerateProcedure.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbxProcedure);
            this.tabPage1.Controls.Add(this.btnGNForm);
            this.tabPage1.Controls.Add(this.BtnGenrateProcedure);
            this.tabPage1.Controls.Add(this.tbxProcedureName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GenrateProcedure";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFormName);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.GnForm);
            this.tabPage2.Controls.Add(this.GVFormGenration);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(406, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GenrateForm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFormName
            // 
            this.btnFormName.Location = new System.Drawing.Point(115, 31);
            this.btnFormName.Name = "btnFormName";
            this.btnFormName.Size = new System.Drawing.Size(234, 20);
            this.btnFormName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Form Name";
            // 
            // GnForm
            // 
            this.GnForm.Location = new System.Drawing.Point(140, 304);
            this.GnForm.Name = "GnForm";
            this.GnForm.Size = new System.Drawing.Size(130, 23);
            this.GnForm.TabIndex = 1;
            this.GnForm.Text = "Geenrate Form";
            this.GnForm.UseVisualStyleBackColor = true;
            this.GnForm.Click += new System.EventHandler(this.GnForm_Click);
            // 
            // GVFormGenration
            // 
            this.GVFormGenration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVFormGenration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fields});
            this.GVFormGenration.Location = new System.Drawing.Point(24, 119);
            this.GVFormGenration.Name = "GVFormGenration";
            this.GVFormGenration.Size = new System.Drawing.Size(353, 150);
            this.GVFormGenration.TabIndex = 0;
            // 
            // fields
            // 
            this.fields.HeaderText = "Fields";
            this.fields.Items.AddRange(new object[] {
            "TextBox",
            "MultitextBox",
            "ComboBox",
            "RadioButton",
            "CheckBox"});
            this.fields.Name = "fields";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 560);
            this.Controls.Add(this.GenerateProcedure);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTableNAme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxServerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkWAuth);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxDataBasrName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rahul Procedure Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GenerateProcedure.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVFormGenration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDataBasrName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTableNAme;
        private System.Windows.Forms.Button BtnGenrateProcedure;
        private System.Windows.Forms.TextBox tbxProcedure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxProcedureName;
        private System.Windows.Forms.RadioButton rdoSql2000;
        private System.Windows.Forms.RadioButton rdosql2005;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.CheckBox chkWAuth;
        private System.Windows.Forms.Button btnGNForm;
        private System.Windows.Forms.TabControl GenerateProcedure;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GVFormGenration;
        private System.Windows.Forms.Button GnForm;
        private System.Windows.Forms.TextBox btnFormName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewComboBoxColumn fields;
    }
}

