namespace RentalProject
{
    partial class RegistrationForm
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
            signup_signInBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            signup_showPass = new CheckBox();
            signup_btn = new Button();
            signup_password = new TextBox();
            label4 = new Label();
            signup_email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            signup_confirmPass = new TextBox();
            label1 = new Label();
            close = new Label();
            signup_name = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(212, 163, 115);
            panel1.Controls.Add(signup_signInBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 553);
            panel1.TabIndex = 1;
            // 
            // signup_signInBtn
            // 
            signup_signInBtn.BackColor = Color.FromArgb(233, 216, 166);
            signup_signInBtn.Cursor = Cursors.Hand;
            signup_signInBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            signup_signInBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            signup_signInBtn.FlatStyle = FlatStyle.Flat;
            signup_signInBtn.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_signInBtn.ForeColor = Color.FromArgb(61, 64, 91);
            signup_signInBtn.Location = new Point(92, 475);
            signup_signInBtn.Name = "signup_signInBtn";
            signup_signInBtn.Size = new Size(169, 41);
            signup_signInBtn.TabIndex = 8;
            signup_signInBtn.Text = "Sign In";
            signup_signInBtn.UseVisualStyleBackColor = false;
            signup_signInBtn.Click += signup_signInBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(212, 163, 115);
            label6.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(61, 64, 91);
            label6.Location = new Point(30, 414);
            label6.Name = "label6";
            label6.Size = new Size(301, 30);
            label6.TabIndex = 4;
            label6.Text = "Already have an Account?";
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
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_showPass.ForeColor = Color.FromArgb(61, 64, 91);
            signup_showPass.Location = new Point(411, 414);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(191, 34);
            signup_showPass.TabIndex = 15;
            signup_showPass.Text = "Show Password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(233, 216, 166);
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            signup_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.FromArgb(61, 64, 91);
            signup_btn.Location = new Point(432, 470);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(291, 46);
            signup_btn.TabIndex = 14;
            signup_btn.Text = "Create an Account";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_password.Location = new Point(411, 290);
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(358, 33);
            signup_password.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(61, 64, 91);
            label4.Location = new Point(411, 252);
            label4.Name = "label4";
            label4.Size = new Size(92, 26);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // signup_email
            // 
            signup_email.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_email.Location = new Point(411, 210);
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(358, 33);
            signup_email.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(61, 64, 91);
            label3.Location = new Point(411, 171);
            label3.Name = "label3";
            label3.Size = new Size(62, 26);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 64, 91);
            label2.Location = new Point(432, 54);
            label2.Name = "label2";
            label2.Size = new Size(113, 34);
            label2.TabIndex = 9;
            label2.Text = "Sign Up";
            // 
            // signup_confirmPass
            // 
            signup_confirmPass.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_confirmPass.Location = new Point(411, 375);
            signup_confirmPass.Name = "signup_confirmPass";
            signup_confirmPass.PasswordChar = '*';
            signup_confirmPass.Size = new Size(358, 33);
            signup_confirmPass.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 64, 91);
            label1.Location = new Point(411, 335);
            label1.Name = "label1";
            label1.Size = new Size(172, 26);
            label1.TabIndex = 16;
            label1.Text = "Confirm Password";
            label1.Click += label1_Click;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Source Code Pro", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.FromArgb(61, 64, 91);
            close.Location = new Point(803, 0);
            close.Name = "close";
            close.Size = new Size(29, 34);
            close.TabIndex = 18;
            close.Text = "X";
            close.Click += Close_Click;
            // 
            // signup_name
            // 
            signup_name.Font = new Font("Source Code Pro", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_name.Location = new Point(411, 135);
            signup_name.Name = "signup_name";
            signup_name.Size = new Size(358, 33);
            signup_name.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Source Code Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(61, 64, 91);
            label7.Location = new Point(411, 97);
            label7.Name = "label7";
            label7.Size = new Size(52, 26);
            label7.TabIndex = 19;
            label7.Text = "Name";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 222);
            ClientSize = new Size(831, 553);
            Controls.Add(signup_name);
            Controls.Add(label7);
            Controls.Add(close);
            Controls.Add(signup_confirmPass);
            Controls.Add(label1);
            Controls.Add(signup_showPass);
            Controls.Add(signup_btn);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button signup_signInBtn;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private CheckBox signup_showPass;
        private Button signup_btn;
        private TextBox signup_password;
        private Label label4;
        private TextBox signup_email;
        private Label label3;
        private Label label2;
        private TextBox signup_confirmPass;
        private Label label1;
        private Label close;
        private TextBox signup_name;
        private Label label7;
    }
}