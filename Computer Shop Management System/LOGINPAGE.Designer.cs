namespace Computer_Shop_Management_System
{
    partial class LOGINPAGE
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.signin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(112, 73);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(210, 22);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(112, 116);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(210, 22);
            this.password.TabIndex = 4;
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.Crimson;
            this.signin.Location = new System.Drawing.Point(150, 184);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(123, 32);
            this.signin.TabIndex = 5;
            this.signin.Text = "Sign in ";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "can\'t sign in? sign up now";
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Crimson;
            this.signup.Location = new System.Drawing.Point(150, 290);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(123, 32);
            this.signup.TabIndex = 7;
            this.signup.Text = "Sign up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // LOGINPAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(425, 436);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LOGINPAGE";
            this.Text = "LOGINPAGE";
            this.Load += new System.EventHandler(this.LOGINPAGE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signup;
    }
}