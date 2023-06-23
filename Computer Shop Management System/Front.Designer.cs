namespace Computer_Shop_Management_System
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.explore = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 141);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO WARES SAYEF\'S COMPUTER SHOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // explore
            // 
            this.explore.BackColor = System.Drawing.Color.Crimson;
            this.explore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explore.Location = new System.Drawing.Point(357, 277);
            this.explore.Name = "explore";
            this.explore.Size = new System.Drawing.Size(284, 67);
            this.explore.TabIndex = 1;
            this.explore.Text = "EXPLORE";
            this.explore.UseVisualStyleBackColor = false;
            this.explore.Click += new System.EventHandler(this.explore_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(357, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "LOGIN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.explore);
            this.Controls.Add(this.label1);
            this.Name = "LOGIN";
            this.Text = "Computer Shop Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button explore;
        private System.Windows.Forms.Button button2;
    }
}

