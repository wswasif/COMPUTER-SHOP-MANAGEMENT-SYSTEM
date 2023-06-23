namespace Computer_Shop_Management_System
{
    partial class adminprofile
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
            this.ED = new System.Windows.Forms.Button();
            this.viewcatalogue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your profile";
            // 
            // ED
            // 
            this.ED.BackColor = System.Drawing.Color.Crimson;
            this.ED.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ED.Location = new System.Drawing.Point(73, 162);
            this.ED.Name = "ED";
            this.ED.Size = new System.Drawing.Size(121, 97);
            this.ED.TabIndex = 1;
            this.ED.Text = "View Employee Details";
            this.ED.UseVisualStyleBackColor = false;
            this.ED.Click += new System.EventHandler(this.ED_Click);
            // 
            // viewcatalogue
            // 
            this.viewcatalogue.BackColor = System.Drawing.Color.Crimson;
            this.viewcatalogue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewcatalogue.Location = new System.Drawing.Point(267, 162);
            this.viewcatalogue.Name = "viewcatalogue";
            this.viewcatalogue.Size = new System.Drawing.Size(121, 97);
            this.viewcatalogue.TabIndex = 2;
            this.viewcatalogue.Text = "View Catalogue";
            this.viewcatalogue.UseVisualStyleBackColor = false;
            this.viewcatalogue.Click += new System.EventHandler(this.viewcatalogue_Click);
            // 
            // adminprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(474, 345);
            this.Controls.Add(this.viewcatalogue);
            this.Controls.Add(this.ED);
            this.Controls.Add(this.label1);
            this.Name = "adminprofile";
            this.Text = "adminprofile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ED;
        private System.Windows.Forms.Button viewcatalogue;
    }
}