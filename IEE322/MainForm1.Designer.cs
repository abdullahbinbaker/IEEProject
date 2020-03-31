namespace IEE322
{
    partial class MainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.arabicButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.AdminLogIn = new System.Windows.Forms.Button();
            this.loanStatusButton = new System.Windows.Forms.Button();
            this.ApplyingForLoanButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // arabicButton
            // 
            resources.ApplyResources(this.arabicButton, "arabicButton");
            this.arabicButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.arabicButton.Name = "arabicButton";
            this.arabicButton.UseVisualStyleBackColor = false;
            this.arabicButton.Click += new System.EventHandler(this.arabicButton_Click);
            // 
            // englishButton
            // 
            resources.ApplyResources(this.englishButton, "englishButton");
            this.englishButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.englishButton.Name = "englishButton";
            this.englishButton.UseVisualStyleBackColor = false;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click_1);
            // 
            // AdminLogIn
            // 
            resources.ApplyResources(this.AdminLogIn, "AdminLogIn");
            this.AdminLogIn.BackColor = System.Drawing.Color.MistyRose;
            this.AdminLogIn.Name = "AdminLogIn";
            this.AdminLogIn.UseVisualStyleBackColor = false;
            this.AdminLogIn.Click += new System.EventHandler(this.AdminLogIn_Click);
            // 
            // loanStatusButton
            // 
            resources.ApplyResources(this.loanStatusButton, "loanStatusButton");
            this.loanStatusButton.BackColor = System.Drawing.Color.Gainsboro;
            this.loanStatusButton.Name = "loanStatusButton";
            this.loanStatusButton.UseVisualStyleBackColor = false;
            this.loanStatusButton.Click += new System.EventHandler(this.loanStatusButton_Click);
            // 
            // ApplyingForLoanButton
            // 
            resources.ApplyResources(this.ApplyingForLoanButton, "ApplyingForLoanButton");
            this.ApplyingForLoanButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ApplyingForLoanButton.Name = "ApplyingForLoanButton";
            this.ApplyingForLoanButton.UseVisualStyleBackColor = false;
            this.ApplyingForLoanButton.Click += new System.EventHandler(this.ApplyingForLoanButton_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::IEE322.Properties.Resources.P91;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainForm1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.arabicButton);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.AdminLogIn);
            this.Controls.Add(this.loanStatusButton);
            this.Controls.Add(this.ApplyingForLoanButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button arabicButton;
        public System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button AdminLogIn;
        private System.Windows.Forms.Button loanStatusButton;
        private System.Windows.Forms.Button ApplyingForLoanButton;
    }
}