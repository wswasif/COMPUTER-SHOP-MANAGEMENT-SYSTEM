namespace Computer_Shop_Management_System
{
    partial class customerpage
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
            this.newtable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newtable)).BeginInit();
            this.SuspendLayout();
            // 
            // newtable
            // 
            this.newtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newtable.Location = new System.Drawing.Point(63, 49);
            this.newtable.Name = "newtable";
            this.newtable.Size = new System.Drawing.Size(677, 382);
            this.newtable.TabIndex = 0;
            this.newtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.newtable_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newtable);
            this.Name = "customerpage";
            this.Text = "customerpage";
            this.Load += new System.EventHandler(this.customerpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newtable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView newtable;
        private System.Windows.Forms.Button button1;
    }
}