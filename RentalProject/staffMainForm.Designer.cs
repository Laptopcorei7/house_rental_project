namespace RentalProject
{
    partial class staffMainForm
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
            panel1 = new Panel();
            label2 = new Label();
            close = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            cutomers_btn = new Button();
            addUser_btn = new Button();
            dashboard_btn = new Button();
            adminWelcome = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            admin_dashboard1 = new admin_dashboard();
            staff_bookHouse1 = new staff_bookHouse();
            admin_customer1 = new admin_customer();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 216, 166);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 51);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 64, 91);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(289, 30);
            label2.TabIndex = 1;
            label2.Text = "House Rental Management";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.FromArgb(61, 64, 91);
            close.Location = new Point(1339, 9);
            close.Name = "close";
            close.Size = new Size(25, 30);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 163, 115);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(cutomers_btn);
            panel2.Controls.Add(addUser_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(adminWelcome);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 810);
            panel2.TabIndex = 2;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(212, 163, 115);
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            logout_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.FromArgb(61, 64, 91);
            logout_btn.Location = new Point(28, 736);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(241, 47);
            logout_btn.TabIndex = 8;
            logout_btn.Text = "Log Out";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // cutomers_btn
            // 
            cutomers_btn.BackColor = Color.FromArgb(212, 163, 115);
            cutomers_btn.Cursor = Cursors.Hand;
            cutomers_btn.FlatAppearance.BorderSize = 0;
            cutomers_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            cutomers_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            cutomers_btn.FlatStyle = FlatStyle.Flat;
            cutomers_btn.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cutomers_btn.ForeColor = Color.FromArgb(61, 64, 91);
            cutomers_btn.Location = new Point(28, 391);
            cutomers_btn.Name = "cutomers_btn";
            cutomers_btn.Size = new Size(241, 47);
            cutomers_btn.TabIndex = 7;
            cutomers_btn.Text = "Customers";
            cutomers_btn.UseVisualStyleBackColor = false;
            cutomers_btn.Click += cutomers_btn_Click;
            // 
            // addUser_btn
            // 
            addUser_btn.BackColor = Color.FromArgb(212, 163, 115);
            addUser_btn.Cursor = Cursors.Hand;
            addUser_btn.FlatAppearance.BorderSize = 0;
            addUser_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            addUser_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            addUser_btn.FlatStyle = FlatStyle.Flat;
            addUser_btn.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addUser_btn.ForeColor = Color.FromArgb(61, 64, 91);
            addUser_btn.Location = new Point(28, 318);
            addUser_btn.Name = "addUser_btn";
            addUser_btn.Size = new Size(241, 47);
            addUser_btn.TabIndex = 5;
            addUser_btn.Text = "Book House";
            addUser_btn.UseVisualStyleBackColor = false;
            addUser_btn.Click += addUser_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(212, 163, 115);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.FromArgb(61, 64, 91);
            dashboard_btn.Location = new Point(28, 249);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(241, 47);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // adminWelcome
            // 
            adminWelcome.AutoSize = true;
            adminWelcome.BackColor = Color.FromArgb(212, 163, 115);
            adminWelcome.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminWelcome.ForeColor = Color.FromArgb(61, 64, 91);
            adminWelcome.Location = new Point(44, 163);
            adminWelcome.Name = "adminWelcome";
            adminWelcome.Size = new Size(197, 34);
            adminWelcome.TabIndex = 4;
            adminWelcome.Text = "Welcome, User";
            adminWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(212, 163, 115);
            pictureBox1.Image = Properties.Resources.icons8_rental_house_contract_100;
            pictureBox1.Location = new Point(86, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(admin_dashboard1);
            panel3.Controls.Add(staff_bookHouse1);
            panel3.Controls.Add(admin_customer1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(290, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(1086, 810);
            panel3.TabIndex = 3;
            // 
            // admin_dashboard1
            // 
            admin_dashboard1.BackColor = Color.FromArgb(244, 241, 222);
            admin_dashboard1.Location = new Point(0, 0);
            admin_dashboard1.Name = "admin_dashboard1";
            admin_dashboard1.Size = new Size(1086, 810);
            admin_dashboard1.TabIndex = 9;
            // 
            // staff_bookHouse1
            // 
            staff_bookHouse1.BackColor = Color.FromArgb(244, 241, 222);
            staff_bookHouse1.Location = new Point(0, 0);
            staff_bookHouse1.Name = "staff_bookHouse1";
            staff_bookHouse1.Size = new Size(1086, 810);
            staff_bookHouse1.TabIndex = 1;
            // 
            // admin_customer1
            // 
            admin_customer1.BackColor = Color.FromArgb(244, 241, 222);
            admin_customer1.Location = new Point(3, 0);
            admin_customer1.Name = "admin_customer1";
            admin_customer1.Size = new Size(1080, 810);
            admin_customer1.TabIndex = 0;
            // 
            // staffMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 222);
            ClientSize = new Size(1376, 861);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "staffMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "staffMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label close;
        private Panel panel2;
        private Button logout_btn;
        private Button cutomers_btn;
        private Button addUser_btn;
        private Button dashboard_btn;
        private Label adminWelcome;
        private PictureBox pictureBox1;
        private Panel panel3;
        private staff_bookHouse staff_bookHouse1;
        private admin_customer admin_customer1;
        private admin_dashboard admin_dashboard1;
    }
}