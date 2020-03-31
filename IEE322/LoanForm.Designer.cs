namespace IEE322
{
    partial class LoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.TextBox();
            this.mobileNumber = new System.Windows.Forms.TextBox();
            this.nationality = new System.Windows.Forms.TextBox();
            this.idNumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.purpose = new System.Windows.Forms.ComboBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.ignore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salary);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.birthDate);
            this.groupBox1.Controls.Add(this.mobileNumber);
            this.groupBox1.Controls.Add(this.nationality);
            this.groupBox1.Controls.Add(this.idNumber);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // salary
            // 
            resources.ApplyResources(this.salary, "salary");
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // address
            // 
            resources.ApplyResources(this.address, "address");
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // birthDate
            // 
            resources.ApplyResources(this.birthDate, "birthDate");
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            // 
            // mobileNumber
            // 
            resources.ApplyResources(this.mobileNumber, "mobileNumber");
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.ReadOnly = true;
            // 
            // nationality
            // 
            resources.ApplyResources(this.nationality, "nationality");
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            // 
            // idNumber
            // 
            resources.ApplyResources(this.idNumber, "idNumber");
            this.idNumber.Name = "idNumber";
            this.idNumber.ReadOnly = true;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.purpose);
            this.groupBox2.Controls.Add(this.amount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // purpose
            // 
            this.purpose.FormattingEnabled = true;
            this.purpose.Items.AddRange(new object[] {
            resources.GetString("purpose.Items"),
            resources.GetString("purpose.Items1"),
            resources.GetString("purpose.Items2"),
            resources.GetString("purpose.Items3"),
            resources.GetString("purpose.Items4"),
            resources.GetString("purpose.Items5")});
            resources.ApplyResources(this.purpose, "purpose");
            this.purpose.Name = "purpose";
            // 
            // amount
            // 
            resources.ApplyResources(this.amount, "amount");
            this.amount.Name = "amount";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.submit, "submit");
            this.submit.Name = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ignore
            // 
            this.ignore.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.ignore, "ignore");
            this.ignore.Name = "ignore";
            this.ignore.UseVisualStyleBackColor = false;
            this.ignore.Click += new System.EventHandler(this.ignore_Click);
            // 
            // LoanForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.ignore);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoanForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox purpose;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button ignore;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox address;
        public System.Windows.Forms.TextBox birthDate;
        public System.Windows.Forms.TextBox mobileNumber;
        public System.Windows.Forms.TextBox nationality;
        public System.Windows.Forms.TextBox idNumber;
        public System.Windows.Forms.TextBox name;
        public System.Windows.Forms.TextBox email;
    }
}