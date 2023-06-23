namespace Computer_Shop_Management_System
{
    partial class productdetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.pid = new System.Windows.Forms.TextBox();
            this.pdetails = new System.Windows.Forms.TextBox();
            this.pprice = new System.Windows.Forms.TextBox();
            this.ppicture = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.producttable = new System.Windows.Forms.DataGridView();
            this.DETAILS = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProductPrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ProductPicture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ProductDetails";
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(156, 52);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(182, 20);
            this.pname.TabIndex = 5;
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(156, 104);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(182, 20);
            this.pid.TabIndex = 6;
            // 
            // pdetails
            // 
            this.pdetails.Location = new System.Drawing.Point(156, 154);
            this.pdetails.Multiline = true;
            this.pdetails.Name = "pdetails";
            this.pdetails.Size = new System.Drawing.Size(182, 59);
            this.pdetails.TabIndex = 7;
            // 
            // pprice
            // 
            this.pprice.Location = new System.Drawing.Point(156, 235);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(102, 20);
            this.pprice.TabIndex = 8;
            // 
            // ppicture
            // 
            this.ppicture.Location = new System.Drawing.Point(156, 292);
            this.ppicture.Name = "ppicture";
            this.ppicture.Size = new System.Drawing.Size(182, 126);
            this.ppicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ppicture.TabIndex = 9;
            this.ppicture.TabStop = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Crimson;
            this.add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(12, 476);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 29);
            this.add.TabIndex = 10;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Crimson;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(126, 476);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(103, 29);
            this.delete.TabIndex = 11;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Crimson;
            this.update.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(235, 476);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(103, 29);
            this.update.TabIndex = 12;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.button3_Click);
            // 
            // producttable
            // 
            this.producttable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.producttable.Location = new System.Drawing.Point(454, 52);
            this.producttable.Name = "producttable";
            this.producttable.Size = new System.Drawing.Size(514, 366);
            this.producttable.TabIndex = 13;
            this.producttable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.producttable_CellContentClick);
            this.producttable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.producttable_RowHeaderMouseClick);
            // 
            // DETAILS
            // 
            this.DETAILS.BackColor = System.Drawing.Color.Crimson;
            this.DETAILS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DETAILS.Location = new System.Drawing.Point(788, 476);
            this.DETAILS.Name = "DETAILS";
            this.DETAILS.Size = new System.Drawing.Size(180, 29);
            this.DETAILS.TabIndex = 14;
            this.DETAILS.Text = "DETAILS";
            this.DETAILS.UseVisualStyleBackColor = false;
            this.DETAILS.Click += new System.EventHandler(this.DETAILS_Click);
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.Color.Crimson;
            this.upload.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(46, 321);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(86, 29);
            this.upload.TabIndex = 15;
            this.upload.Text = "UPLOAD";
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.button4_Click);
            // 
            // productdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 538);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.DETAILS);
            this.Controls.Add(this.producttable);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ppicture);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.pdetails);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "productdetails";
            this.Text = "productdetails";
            ((System.ComponentModel.ISupportInitialize)(this.ppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.TextBox pdetails;
        private System.Windows.Forms.TextBox pprice;
        private System.Windows.Forms.PictureBox ppicture;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridView producttable;
        private System.Windows.Forms.Button DETAILS;
        private System.Windows.Forms.Button upload;
    }
}