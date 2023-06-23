namespace Computer_Shop_Management_System
{
    partial class whosgonnalogin
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
            this.admin = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN AS";
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.Crimson;
            this.admin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(27, 200);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(129, 50);
            this.admin.TabIndex = 1;
            this.admin.Text = "ADMIN";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.Crimson;
            this.employee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.Location = new System.Drawing.Point(193, 200);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(129, 50);
            this.employee.TabIndex = 2;
            this.employee.Text = "EMPLOYEE";
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.Crimson;
            this.customer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(357, 200);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(129, 50);
            this.customer.TabIndex = 3;
            this.customer.Text = "CUSTOMER";
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // whosgonnalogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(511, 323);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.label1);
            this.Name = "whosgonnalogin";
            this.Text = "whosgonnalogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button customer;
    }
}