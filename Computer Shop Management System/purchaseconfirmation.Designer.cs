namespace Computer_Shop_Management_System
{
    partial class purchaseconfirmation
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
            this.label2 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thank you for the purchase.We will deliver you the product by tomorrow and the pa" +
    "yment system is cash on delivery";
            // 
            // confirm
            // 
            this.confirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confirm.Location = new System.Drawing.Point(122, 38);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(538, 273);
            this.confirm.TabIndex = 2;
            // 
            // purchaseconfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 400);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label2);
            this.Name = "purchaseconfirmation";
            this.Text = "purchaseconfirmation";
            this.Load += new System.EventHandler(this.purchaseconfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.confirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView confirm;
    }
}