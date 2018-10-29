namespace Medepia
{
    partial class Form1
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
            this.lbl_ls_name = new System.Windows.Forms.Label();
            this.pb_ls_logo = new System.Windows.Forms.PictureBox();
            this.lbl_ls_tourname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.denemeLbl3 = new System.Windows.Forms.Label();
            this.denemeLbl2 = new System.Windows.Forms.Label();
            this.denemeLbl1 = new System.Windows.Forms.Label();
            this.denemeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ls_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ls_name
            // 
            this.lbl_ls_name.AutoSize = true;
            this.lbl_ls_name.Location = new System.Drawing.Point(423, 9);
            this.lbl_ls_name.Name = "lbl_ls_name";
            this.lbl_ls_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_ls_name.TabIndex = 2;
            this.lbl_ls_name.Text = "label1";
            // 
            // pb_ls_logo
            // 
            this.pb_ls_logo.Location = new System.Drawing.Point(491, 25);
            this.pb_ls_logo.Name = "pb_ls_logo";
            this.pb_ls_logo.Size = new System.Drawing.Size(139, 104);
            this.pb_ls_logo.TabIndex = 3;
            this.pb_ls_logo.TabStop = false;
            // 
            // lbl_ls_tourname
            // 
            this.lbl_ls_tourname.AutoSize = true;
            this.lbl_ls_tourname.Location = new System.Drawing.Point(530, 9);
            this.lbl_ls_tourname.Name = "lbl_ls_tourname";
            this.lbl_ls_tourname.Size = new System.Drawing.Size(35, 13);
            this.lbl_ls_tourname.TabIndex = 4;
            this.lbl_ls_tourname.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 187);
            this.dataGridView1.TabIndex = 32;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(368, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(372, 150);
            this.dataGridView2.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Oynat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.run_Click);
            // 
            // denemeLbl3
            // 
            this.denemeLbl3.AutoSize = true;
            this.denemeLbl3.Location = new System.Drawing.Point(27, 237);
            this.denemeLbl3.Name = "denemeLbl3";
            this.denemeLbl3.Size = new System.Drawing.Size(35, 13);
            this.denemeLbl3.TabIndex = 45;
            this.denemeLbl3.Text = "label3";
            // 
            // denemeLbl2
            // 
            this.denemeLbl2.AutoSize = true;
            this.denemeLbl2.Location = new System.Drawing.Point(27, 213);
            this.denemeLbl2.Name = "denemeLbl2";
            this.denemeLbl2.Size = new System.Drawing.Size(35, 13);
            this.denemeLbl2.TabIndex = 44;
            this.denemeLbl2.Text = "label2";
            // 
            // denemeLbl1
            // 
            this.denemeLbl1.AutoSize = true;
            this.denemeLbl1.Location = new System.Drawing.Point(27, 187);
            this.denemeLbl1.Name = "denemeLbl1";
            this.denemeLbl1.Size = new System.Drawing.Size(35, 13);
            this.denemeLbl1.TabIndex = 43;
            this.denemeLbl1.Text = "label1";
            // 
            // denemeLbl
            // 
            this.denemeLbl.AutoSize = true;
            this.denemeLbl.Location = new System.Drawing.Point(27, 156);
            this.denemeLbl.Name = "denemeLbl";
            this.denemeLbl.Size = new System.Drawing.Size(35, 13);
            this.denemeLbl.TabIndex = 42;
            this.denemeLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 749);
            this.Controls.Add(this.denemeLbl3);
            this.Controls.Add(this.denemeLbl2);
            this.Controls.Add(this.denemeLbl1);
            this.Controls.Add(this.denemeLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_ls_tourname);
            this.Controls.Add(this.pb_ls_logo);
            this.Controls.Add(this.lbl_ls_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ls_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ls_name;
        private System.Windows.Forms.PictureBox pb_ls_logo;
        private System.Windows.Forms.Label lbl_ls_tourname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label denemeLbl3;
        private System.Windows.Forms.Label denemeLbl2;
        private System.Windows.Forms.Label denemeLbl1;
        private System.Windows.Forms.Label denemeLbl;
    }
}

