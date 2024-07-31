namespace RentalProject
{
    partial class admin_addHouses
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            addHouse_update = new Button();
            addHouse_delete = new Button();
            addHouse_clear = new Button();
            addHouse_importBtn = new Button();
            panel3 = new Panel();
            addHouse_picture = new PictureBox();
            addHouseBtn = new Button();
            addHouse_availableDate = new DateTimePicker();
            addHouse_status = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            addHouse_depositAmount = new TextBox();
            label9 = new Label();
            addHouse_rentAmount = new TextBox();
            label8 = new Label();
            addHouse_numOfBathrooms = new NumericUpDown();
            label7 = new Label();
            addHouse_numOfBedrooms = new NumericUpDown();
            addHouse_description = new TextBox();
            label6 = new Label();
            addHouse_address = new TextBox();
            label5 = new Label();
            label4 = new Label();
            addHouse_name = new TextBox();
            label3 = new Label();
            addHouse_ID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addHouse_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addHouse_numOfBathrooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addHouse_numOfBedrooms).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(212, 163, 115);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(26, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 419);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 64, 91);
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 2;
            label1.Text = "Data On Houses";
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
            dataGridView1.Location = new Point(18, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(967, 330);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 163, 115);
            panel2.Controls.Add(addHouse_update);
            panel2.Controls.Add(addHouse_delete);
            panel2.Controls.Add(addHouse_clear);
            panel2.Controls.Add(addHouse_importBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(addHouseBtn);
            panel2.Controls.Add(addHouse_availableDate);
            panel2.Controls.Add(addHouse_status);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(addHouse_depositAmount);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(addHouse_rentAmount);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(addHouse_numOfBathrooms);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addHouse_numOfBedrooms);
            panel2.Controls.Add(addHouse_description);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addHouse_address);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addHouse_name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addHouse_ID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(26, 446);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 349);
            panel2.TabIndex = 1;
            // 
            // addHouse_update
            // 
            addHouse_update.BackColor = Color.FromArgb(233, 216, 166);
            addHouse_update.FlatAppearance.BorderSize = 0;
            addHouse_update.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            addHouse_update.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            addHouse_update.FlatStyle = FlatStyle.Flat;
            addHouse_update.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addHouse_update.ForeColor = Color.FromArgb(61, 64, 91);
            addHouse_update.Location = new Point(208, 281);
            addHouse_update.Name = "addHouse_update";
            addHouse_update.Size = new Size(167, 56);
            addHouse_update.TabIndex = 30;
            addHouse_update.Text = "Update";
            addHouse_update.UseVisualStyleBackColor = false;
            addHouse_update.Click += addHouse_update_Click;
            // 
            // addHouse_delete
            // 
            addHouse_delete.BackColor = Color.FromArgb(233, 216, 166);
            addHouse_delete.FlatAppearance.BorderSize = 0;
            addHouse_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            addHouse_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            addHouse_delete.FlatStyle = FlatStyle.Flat;
            addHouse_delete.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addHouse_delete.ForeColor = Color.FromArgb(61, 64, 91);
            addHouse_delete.Location = new Point(418, 281);
            addHouse_delete.Name = "addHouse_delete";
            addHouse_delete.Size = new Size(167, 56);
            addHouse_delete.TabIndex = 29;
            addHouse_delete.Text = "Delete";
            addHouse_delete.UseVisualStyleBackColor = false;
            addHouse_delete.Click += addHouse_delete_Click;
            // 
            // addHouse_clear
            // 
            addHouse_clear.BackColor = Color.FromArgb(233, 216, 166);
            addHouse_clear.FlatAppearance.BorderSize = 0;
            addHouse_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            addHouse_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            addHouse_clear.FlatStyle = FlatStyle.Flat;
            addHouse_clear.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addHouse_clear.ForeColor = Color.FromArgb(61, 64, 91);
            addHouse_clear.Location = new Point(609, 281);
            addHouse_clear.Name = "addHouse_clear";
            addHouse_clear.Size = new Size(167, 56);
            addHouse_clear.TabIndex = 28;
            addHouse_clear.Text = "Clear";
            addHouse_clear.UseVisualStyleBackColor = false;
            addHouse_clear.Click += addHouse_clear_Click;
            // 
            // addHouse_importBtn
            // 
            addHouse_importBtn.BackColor = Color.FromArgb(233, 216, 166);
            addHouse_importBtn.FlatAppearance.BorderSize = 0;
            addHouse_importBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            addHouse_importBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            addHouse_importBtn.FlatStyle = FlatStyle.Flat;
            addHouse_importBtn.Font = new Font("Source Code Pro", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addHouse_importBtn.ForeColor = Color.FromArgb(61, 64, 91);
            addHouse_importBtn.Location = new Point(864, 147);
            addHouse_importBtn.Name = "addHouse_importBtn";
            addHouse_importBtn.Size = new Size(118, 44);
            addHouse_importBtn.TabIndex = 27;
            addHouse_importBtn.Text = "Import";
            addHouse_importBtn.UseVisualStyleBackColor = false;
            addHouse_importBtn.Click += addHouse_importBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(addHouse_picture);
            panel3.Location = new Point(846, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 115);
            panel3.TabIndex = 26;
            // 
            // addHouse_picture
            // 
            addHouse_picture.Location = new Point(0, 0);
            addHouse_picture.Name = "addHouse_picture";
            addHouse_picture.Size = new Size(136, 115);
            addHouse_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            addHouse_picture.TabIndex = 0;
            addHouse_picture.TabStop = false;
            // 
            // addHouseBtn
            // 
            addHouseBtn.BackColor = Color.FromArgb(233, 216, 166);
            addHouseBtn.FlatAppearance.BorderSize = 0;
            addHouseBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            addHouseBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            addHouseBtn.FlatStyle = FlatStyle.Flat;
            addHouseBtn.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addHouseBtn.ForeColor = Color.FromArgb(61, 64, 91);
            addHouseBtn.Location = new Point(15, 281);
            addHouseBtn.Name = "addHouseBtn";
            addHouseBtn.Size = new Size(167, 56);
            addHouseBtn.TabIndex = 25;
            addHouseBtn.Text = "Add House";
            addHouseBtn.UseVisualStyleBackColor = false;
            addHouseBtn.Click += addHouseBtn_Click;
            // 
            // addHouse_availableDate
            // 
            addHouse_availableDate.Location = new Point(609, 180);
            addHouse_availableDate.Name = "addHouse_availableDate";
            addHouse_availableDate.Size = new Size(250, 27);
            addHouse_availableDate.TabIndex = 24;
            // 
            // addHouse_status
            // 
            addHouse_status.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_status.FormattingEnabled = true;
            addHouse_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            addHouse_status.Location = new Point(529, 229);
            addHouse_status.Name = "addHouse_status";
            addHouse_status.Size = new Size(151, 31);
            addHouse_status.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(61, 64, 91);
            label11.Location = new Point(441, 229);
            label11.Name = "label11";
            label11.Size = new Size(82, 26);
            label11.TabIndex = 22;
            label11.Text = "Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(61, 64, 91);
            label10.Location = new Point(441, 183);
            label10.Name = "label10";
            label10.Size = new Size(162, 26);
            label10.TabIndex = 20;
            label10.Text = "Avaliable Date:";
            // 
            // addHouse_depositAmount
            // 
            addHouse_depositAmount.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_depositAmount.Location = new Point(629, 128);
            addHouse_depositAmount.Name = "addHouse_depositAmount";
            addHouse_depositAmount.Size = new Size(196, 33);
            addHouse_depositAmount.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(61, 64, 91);
            label9.Location = new Point(441, 128);
            label9.Name = "label9";
            label9.Size = new Size(192, 26);
            label9.TabIndex = 18;
            label9.Text = "Deposit Amount($):";
            // 
            // addHouse_rentAmount
            // 
            addHouse_rentAmount.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_rentAmount.Location = new Point(609, 77);
            addHouse_rentAmount.Name = "addHouse_rentAmount";
            addHouse_rentAmount.Size = new Size(196, 33);
            addHouse_rentAmount.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(61, 64, 91);
            label8.Location = new Point(441, 77);
            label8.Name = "label8";
            label8.Size = new Size(162, 26);
            label8.TabIndex = 16;
            label8.Text = "Rent Amount($):";
            // 
            // addHouse_numOfBathrooms
            // 
            addHouse_numOfBathrooms.Font = new Font("Source Code Pro", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_numOfBathrooms.ForeColor = Color.FromArgb(61, 64, 91);
            addHouse_numOfBathrooms.Location = new Point(659, 24);
            addHouse_numOfBathrooms.Name = "addHouse_numOfBathrooms";
            addHouse_numOfBathrooms.Size = new Size(111, 29);
            addHouse_numOfBathrooms.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(61, 64, 91);
            label7.Location = new Point(441, 24);
            label7.Name = "label7";
            label7.Size = new Size(212, 26);
            label7.TabIndex = 14;
            label7.Text = "Number of Bathrooms:";
            // 
            // addHouse_numOfBedrooms
            // 
            addHouse_numOfBedrooms.Font = new Font("Source Code Pro", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_numOfBedrooms.ForeColor = Color.FromArgb(61, 64, 91);
            addHouse_numOfBedrooms.Location = new Point(226, 238);
            addHouse_numOfBedrooms.Name = "addHouse_numOfBedrooms";
            addHouse_numOfBedrooms.Size = new Size(111, 29);
            addHouse_numOfBedrooms.TabIndex = 13;
            // 
            // addHouse_description
            // 
            addHouse_description.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_description.Location = new Point(144, 128);
            addHouse_description.Name = "addHouse_description";
            addHouse_description.Size = new Size(168, 33);
            addHouse_description.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(61, 64, 91);
            label6.Location = new Point(15, 128);
            label6.Name = "label6";
            label6.Size = new Size(132, 26);
            label6.TabIndex = 11;
            label6.Text = "Description:";
            // 
            // addHouse_address
            // 
            addHouse_address.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_address.Location = new Point(116, 183);
            addHouse_address.Name = "addHouse_address";
            addHouse_address.Size = new Size(196, 33);
            addHouse_address.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(61, 64, 91);
            label5.Location = new Point(18, 183);
            label5.Name = "label5";
            label5.Size = new Size(92, 26);
            label5.TabIndex = 9;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(61, 64, 91);
            label4.Location = new Point(18, 238);
            label4.Name = "label4";
            label4.Size = new Size(202, 26);
            label4.TabIndex = 7;
            label4.Text = "Number of Bedrooms:";
            // 
            // addHouse_name
            // 
            addHouse_name.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_name.Location = new Point(173, 77);
            addHouse_name.Name = "addHouse_name";
            addHouse_name.Size = new Size(150, 33);
            addHouse_name.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(61, 64, 91);
            label3.Location = new Point(15, 77);
            label3.Name = "label3";
            label3.Size = new Size(152, 26);
            label3.TabIndex = 5;
            label3.Text = "Name of House:";
            // 
            // addHouse_ID
            // 
            addHouse_ID.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addHouse_ID.Location = new Point(116, 17);
            addHouse_ID.Name = "addHouse_ID";
            addHouse_ID.Size = new Size(155, 33);
            addHouse_ID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 64, 91);
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(102, 26);
            label2.TabIndex = 3;
            label2.Text = "House ID:";
            // 
            // admin_addHouses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 222);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admin_addHouses";
            Size = new Size(1056, 814);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)addHouse_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)addHouse_numOfBathrooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)addHouse_numOfBedrooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox addHouse_ID;
        private NumericUpDown addHouse_numOfBathrooms;
        private Label label7;
        private NumericUpDown addHouse_numOfBedrooms;
        private TextBox addHouse_description;
        private Label label6;
        private TextBox addHouse_address;
        private Label label5;
        private Label label4;
        private TextBox addHouse_name;
        private DateTimePicker addHouse_availableDate;
        private ComboBox addHouse_status;
        private Label label11;
        private Label label10;
        private TextBox addHouse_depositAmount;
        private Label label9;
        private TextBox addHouse_rentAmount;
        private Label label8;
        private Panel panel3;
        private Button addHouseBtn;
        private Button addHouse_importBtn;
        private PictureBox addHouse_picture;
        private Button addHouse_update;
        private Button addHouse_delete;
        private Button addHouse_clear;
    }
}
