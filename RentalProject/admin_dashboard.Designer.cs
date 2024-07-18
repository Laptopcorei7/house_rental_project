namespace RentalProject
{
    partial class admin_dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_dashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel5 = new Panel();
            panel4 = new Panel();
            panel9 = new Panel();
            label8 = new Label();
            totalProfit = new Label();
            pictureBox4 = new PictureBox();
            panel8 = new Panel();
            todaysProfit = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel7 = new Panel();
            availableHouses = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel6 = new Panel();
            totalStaff = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(212, 163, 115);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(15, 249);
            panel5.Name = "panel5";
            panel5.Size = new Size(1026, 554);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(233, 216, 166);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(15, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(1026, 212);
            panel4.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(212, 163, 115);
            panel9.Controls.Add(label8);
            panel9.Controls.Add(totalProfit);
            panel9.Controls.Add(pictureBox4);
            panel9.Location = new Point(777, 21);
            panel9.Name = "panel9";
            panel9.Size = new Size(235, 153);
            panel9.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Source Code Pro", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(61, 64, 91);
            label8.Location = new Point(3, 105);
            label8.Name = "label8";
            label8.Size = new Size(144, 27);
            label8.TabIndex = 6;
            label8.Text = "Total Profit";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalProfit
            // 
            totalProfit.AutoSize = true;
            totalProfit.Font = new Font("Source Code Pro", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalProfit.ForeColor = Color.FromArgb(61, 64, 91);
            totalProfit.Location = new Point(105, 23);
            totalProfit.Name = "totalProfit";
            totalProfit.Size = new Size(56, 27);
            totalProfit.TabIndex = 6;
            totalProfit.Text = "$0.0";
            totalProfit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(212, 163, 115);
            panel8.Controls.Add(todaysProfit);
            panel8.Controls.Add(pictureBox3);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(520, 21);
            panel8.Name = "panel8";
            panel8.Size = new Size(225, 153);
            panel8.TabIndex = 1;
            // 
            // todaysProfit
            // 
            todaysProfit.AutoSize = true;
            todaysProfit.Font = new Font("Source Code Pro", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todaysProfit.ForeColor = Color.FromArgb(61, 64, 91);
            todaysProfit.Location = new Point(111, 23);
            todaysProfit.Name = "todaysProfit";
            todaysProfit.Size = new Size(56, 27);
            todaysProfit.TabIndex = 5;
            todaysProfit.Text = "$0.0";
            todaysProfit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(23, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Source Code Pro", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(61, 64, 91);
            label6.Location = new Point(14, 105);
            label6.Name = "label6";
            label6.Size = new Size(166, 27);
            label6.TabIndex = 4;
            label6.Text = "Today's Profit";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(212, 163, 115);
            panel7.Controls.Add(availableHouses);
            panel7.Controls.Add(pictureBox2);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(266, 21);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 153);
            panel7.TabIndex = 1;
            // 
            // availableHouses
            // 
            availableHouses.AutoSize = true;
            availableHouses.Font = new Font("Source Code Pro", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            availableHouses.ForeColor = Color.FromArgb(61, 64, 91);
            availableHouses.Location = new Point(111, 23);
            availableHouses.Name = "availableHouses";
            availableHouses.Size = new Size(23, 27);
            availableHouses.TabIndex = 3;
            availableHouses.Text = "0";
            availableHouses.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Source Code Pro", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(61, 64, 91);
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(188, 27);
            label4.TabIndex = 2;
            label4.Text = "Available Houses";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(212, 163, 115);
            panel6.Controls.Add(totalStaff);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(17, 21);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 153);
            panel6.TabIndex = 0;
            // 
            // totalStaff
            // 
            totalStaff.AutoSize = true;
            totalStaff.Font = new Font("Source Code Pro", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalStaff.ForeColor = Color.FromArgb(61, 64, 91);
            totalStaff.Location = new Point(100, 23);
            totalStaff.Name = "totalStaff";
            totalStaff.Size = new Size(23, 27);
            totalStaff.TabIndex = 1;
            totalStaff.Text = "0";
            totalStaff.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 64, 91);
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(133, 27);
            label1.TabIndex = 0;
            label1.Text = "Total Staff";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_users_70;
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(233, 216, 166);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(233, 216, 166);
            dataGridViewCellStyle1.Font = new Font("Source Code Pro", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(61, 64, 91);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(17, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(982, 457);
            dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 64, 91);
            label2.Location = new Point(17, 23);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 7;
            label2.Text = "All Houses";
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 222);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Name = "admin_dashboard";
            Size = new Size(1056, 814);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel4;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private Label totalStaff;
        private Label todaysProfit;
        private Label label6;
        private Label availableHouses;
        private Label label4;
        private Label totalProfit;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label2;
    }
}
