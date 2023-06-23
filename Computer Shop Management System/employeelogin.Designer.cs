namespace Computer_Shop_Management_System
{
    partial class employeelogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(145, 72);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(188, 20);
            this.userid.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(145, 113);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(188, 20);
            this.password.TabIndex = 3;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Crimson;
            this.signup.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(110, 228);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(160, 32);
            this.signup.TabIndex = 4;
            this.signup.Text = "SIGNUP";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.Crimson;
            this.signin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Location = new System.Drawing.Point(110, 170);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(160, 32);
            this.signin.TabIndex = 5;
            this.signin.Text = "SIGNIN";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // employeelogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 310);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "employeelogin";
            this.Text = "employeelogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button signin;
    }
}