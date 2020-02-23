namespace EMS.View
{
    partial class ManagementForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRecordHours = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbliD = new System.Windows.Forms.Label();
            this.dgvHours = new System.Windows.Forms.DataGridView();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listviewEmployees = new System.Windows.Forms.ListView();
            this.cceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cceFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgvHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Go back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRecordHours
            // 
            this.btnRecordHours.Location = new System.Drawing.Point(413, 150);
            this.btnRecordHours.Name = "btnRecordHours";
            this.btnRecordHours.Size = new System.Drawing.Size(170, 33);
            this.btnRecordHours.TabIndex = 1;
            this.btnRecordHours.Text = "Record Employee Hours";
            this.btnRecordHours.UseVisualStyleBackColor = true;
            this.btnRecordHours.Click += new System.EventHandler(this.btnRecordHours_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Work Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hours";
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Location = new System.Drawing.Point(413, 75);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(212, 20);
            this.dtpWorkDate.TabIndex = 8;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(413, 116);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(212, 20);
            this.txtHours.TabIndex = 11;
            this.txtHours.Text = "7.2";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 33);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Update Employee";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(193, 239);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(212, 20);
            this.txtPhone.TabIndex = 23;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(193, 198);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(212, 20);
            this.dtpDOB.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(193, 116);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(212, 20);
            this.txtLName.TabIndex = 20;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(193, 75);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(212, 20);
            this.txtFName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Last name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "First name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(353, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Update Employees";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(353, 28);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(86, 13);
            this.labelid.TabIndex = 26;
            this.labelid.Text = "Employee ID: ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(9, 374);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 22);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbliD
            // 
            this.lbliD.AutoSize = true;
            this.lbliD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliD.Location = new System.Drawing.Point(438, 28);
            this.lbliD.Name = "lbliD";
            this.lbliD.Size = new System.Drawing.Size(0, 13);
            this.lbliD.TabIndex = 30;
            // 
            // dgvHours
            // 
            this.dgvHours.AllowUserToAddRows = false;
            this.dgvHours.AllowUserToDeleteRows = false;
            this.dgvHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHours.Location = new System.Drawing.Point(412, 199);
            this.dgvHours.Name = "dgvHours";
            this.dgvHours.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHours.Size = new System.Drawing.Size(366, 197);
            this.dgvHours.TabIndex = 32;
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(9, 25);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(176, 20);
            this.txtSearchEmail.TabIndex = 34;
            this.txtSearchEmail.TextChanged += new System.EventHandler(this.txtSearchEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search Employee by Email (Delete to text to stop search)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listviewEmployees
            // 
            this.listviewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cceID,
            this.cceFullName});
            this.listviewEmployees.FullRowSelect = true;
            this.listviewEmployees.HideSelection = false;
            this.listviewEmployees.Location = new System.Drawing.Point(9, 58);
            this.listviewEmployees.Name = "listviewEmployees";
            this.listviewEmployees.Size = new System.Drawing.Size(175, 309);
            this.listviewEmployees.TabIndex = 36;
            this.listviewEmployees.UseCompatibleStateImageBehavior = false;
            this.listviewEmployees.View = System.Windows.Forms.View.Details;
            this.listviewEmployees.SelectedIndexChanged += new System.EventHandler(this.listviewEmployees_SelectedIndexChanged);
            // 
            // cceID
            // 
            this.cceID.Text = "ID";
            this.cceID.Width = 36;
            // 
            // cceFullName
            // 
            this.cceFullName.Text = "Full Name";
            this.cceFullName.Width = 100;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 404);
            this.Controls.Add(this.listviewEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchEmail);
            this.Controls.Add(this.dgvHours);
            this.Controls.Add(this.lbliD);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.dtpWorkDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecordHours);
            this.Controls.Add(this.btnCancel);
            this.Name = "ManagementForm";
            this.Text = "Management Form";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRecordHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbliD;
        private System.Windows.Forms.DataGridView dgvHours;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView listviewEmployees;
        public System.Windows.Forms.ColumnHeader cceID;
        private System.Windows.Forms.ColumnHeader cceFullName;
    }
}