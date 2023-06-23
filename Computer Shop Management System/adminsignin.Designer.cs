namespace Computer_Shop_Management_System
{
    partial class adminsignin
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
            this.login = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(132, 100);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(205, 20);
            this.userid.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(132, 148);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(205, 20);
            this.password.TabIndex = 3;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Crimson;
            this.login.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(153, 221);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(106, 28);
            this.login.TabIndex = 4;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Crimson;
            this.signup.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(153, 270);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(106, 28);
            this.signup.TabIndex = 5;
            this.signup.Text = "SIGNUP";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // adminsignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminsignin";
            this.Text = "adminsignin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signup;
    }
}