namespace RentalProject
{
    partial class LoginFile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            login_createAcc = new Button();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            close = new Label();
            label2 = new Label();
            label3 = new Label();
            login_email = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_btn = new Button();
            login_showPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(212, 163, 115);
            panel1.Controls.Add(login_createAcc);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 553);
            panel1.TabIndex = 0;
            // 
            // login_createAcc
            // 
            login_createAcc.BackColor = Color.FromArgb(233, 216, 166);
            login_createAcc.Cursor = Cursors.Hand;
            login_createAcc.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            login_createAcc.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            login_createAcc.FlatStyle = FlatStyle.Flat;
            login_createAcc.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_createAcc.ForeColor = Color.FromArgb(61, 64, 91);
            login_createAcc.Location = new Point(39, 473);
            login_createAcc.Name = "login_createAcc";
            login_createAcc.Size = new Size(281, 52);
            login_createAcc.TabIndex = 8;
            login_createAcc.Text = "Create an Account";
            login_createAcc.UseVisualStyleBackColor = false;
            login_createAcc.Click += login_createAcc_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(212, 163, 115);
            label6.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(61, 64, 91);
            label6.Location = new Point(211, 415);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 4;
            label6.Text = "Sign Up?";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(212, 163, 115);
            label5.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(61, 64, 91);
            label5.Location = new Point(39, 210);
            label5.Name = "label5";
            label5.Size = new Size(281, 34);
            label5.TabIndex = 3;
            label5.Text = "House Rental System";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(212, 163, 115);
            pictureBox1.Image = Properties.Resources.icons8_rental_house_contract_100;
            pictureBox1.Location = new Point(114, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(808, 0);
            close.Name = "close";
            close.Size = new Size(22, 26);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 64, 91);
            label2.Location = new Point(430, 87);
            label2.Name = "label2";
            label2.Size = new Size(281, 34);
            label2.TabIndex = 2;
            label2.Text = "Welcome Back, User!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(61, 64, 91);
            label3.Location = new Point(409, 160);
            label3.Name = "label3";
            label3.Size = new Size(62, 26);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // login_email
            // 
            login_email.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_email.Location = new Point(409, 189);
            login_email.Name = "login_email";
            login_email.Size = new Size(358, 33);
            login_email.TabIndex = 4;
            // 
            // login_password
            // 
            login_password.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(409, 266);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(358, 33);
            login_password.TabIndex = 6;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(61, 64, 91);
            label4.Location = new Point(409, 237);
            label4.Name = "label4";
            label4.Size = new Size(92, 26);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(233, 216, 166);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.FromArgb(61, 64, 91);
            login_btn.Location = new Point(469, 366);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(203, 46);
            login_btn.TabIndex = 7;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_showPass.ForeColor = Color.FromArgb(61, 64, 91);
            login_showPass.Location = new Point(409, 305);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(191, 34);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // LoginFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 222);
            ClientSize = new Size(831, 553);
            Controls.Add(login_showPass);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label2;
        private Label label3;
        private TextBox login_email;
        private TextBox login_password;
        private Label label4;
        private Button login_btn;
        private PictureBox pictureBox1;
        private Label label5;
        private Button login_createAcc;
        private Label label6;
        private CheckBox login_showPass;
    }
}
