namespace RentalProject
{
    partial class clientInfo
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
            clientInfo_clearBtn = new Button();
            clientInfo_bookBtn = new Button();
            clientInfo_gender = new ComboBox();
            label5 = new Label();
            clientInfo_contactNum = new TextBox();
            label4 = new Label();
            clientInfo_email = new TextBox();
            clientInfo_bookID = new Label();
            clientInfo_name = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(961, 51);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 64, 91);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(253, 30);
            label2.TabIndex = 1;
            label2.Text = "Client's Information";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.FromArgb(61, 64, 91);
            close.Location = new Point(924, 9);
            close.Name = "close";
            close.Size = new Size(25, 30);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 163, 115);
            panel2.Controls.Add(clientInfo_clearBtn);
            panel2.Controls.Add(clientInfo_bookBtn);
            panel2.Controls.Add(clientInfo_gender);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(clientInfo_contactNum);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(clientInfo_email);
            panel2.Controls.Add(clientInfo_bookID);
            panel2.Controls.Add(clientInfo_name);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(22, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(917, 536);
            panel2.TabIndex = 3;
            // 
            // clientInfo_clearBtn
            // 
            clientInfo_clearBtn.BackColor = Color.FromArgb(233, 216, 166);
            clientInfo_clearBtn.FlatAppearance.BorderSize = 0;
            clientInfo_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            clientInfo_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            clientInfo_clearBtn.FlatStyle = FlatStyle.Flat;
            clientInfo_clearBtn.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientInfo_clearBtn.ForeColor = Color.FromArgb(61, 64, 91);
            clientInfo_clearBtn.Location = new Point(501, 424);
            clientInfo_clearBtn.Name = "clientInfo_clearBtn";
            clientInfo_clearBtn.Size = new Size(320, 62);
            clientInfo_clearBtn.TabIndex = 27;
            clientInfo_clearBtn.Text = "Clear";
            clientInfo_clearBtn.UseVisualStyleBackColor = false;
            clientInfo_clearBtn.Click += clientInfo_clearBtn_Click;
            // 
            // clientInfo_bookBtn
            // 
            clientInfo_bookBtn.BackColor = Color.FromArgb(233, 216, 166);
            clientInfo_bookBtn.FlatAppearance.BorderSize = 0;
            clientInfo_bookBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(129, 178, 154);
            clientInfo_bookBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 178, 154);
            clientInfo_bookBtn.FlatStyle = FlatStyle.Flat;
            clientInfo_bookBtn.Font = new Font("Source Code Pro", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientInfo_bookBtn.ForeColor = Color.FromArgb(61, 64, 91);
            clientInfo_bookBtn.Location = new Point(88, 424);
            clientInfo_bookBtn.Name = "clientInfo_bookBtn";
            clientInfo_bookBtn.Size = new Size(320, 62);
            clientInfo_bookBtn.TabIndex = 26;
            clientInfo_bookBtn.Text = "Book Now";
            clientInfo_bookBtn.UseVisualStyleBackColor = false;
            clientInfo_bookBtn.Click += clientInfo_bookBtn_Click;
            // 
            // clientInfo_gender
            // 
            clientInfo_gender.Font = new Font("Source Code Pro", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientInfo_gender.FormattingEnabled = true;
            clientInfo_gender.Items.AddRange(new object[] { "Male", "Female" });
            clientInfo_gender.Location = new Point(614, 154);
            clientInfo_gender.Name = "clientInfo_gender";
            clientInfo_gender.Size = new Size(151, 34);
            clientInfo_gender.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(61, 64, 91);
            label5.Location = new Point(535, 157);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 15;
            label5.Text = "Gender:";
            // 
            // clientInfo_contactNum
            // 
            clientInfo_contactNum.Font = new Font("Source Code Pro", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientInfo_contactNum.Location = new Point(218, 260);
            clientInfo_contactNum.Name = "clientInfo_contactNum";
            clientInfo_contactNum.Size = new Size(191, 30);
            clientInfo_contactNum.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(61, 64, 91);
            label4.Location = new Point(54, 260);
            label4.Name = "label4";
            label4.Size = new Size(145, 23);
            label4.TabIndex = 13;
            label4.Text = "Contact Number:";
            // 
            // clientInfo_email
            // 
            clientInfo_email.Font = new Font("Source Code Pro", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientInfo_email.Location = new Point(218, 201);
            clientInfo_email.Name = "clientInfo_email";
            clientInfo_email.Size = new Size(191, 30);
            clientInfo_email.TabIndex = 12;
            // 
            // clientInfo_bookID
            // 
            clientInfo_bookID.AutoSize = true;
            clientInfo_bookID.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientInfo_bookID.ForeColor = Color.FromArgb(61, 64, 91);
            clientInfo_bookID.Location = new Point(218, 108);
            clientInfo_bookID.Name = "clientInfo_bookID";
            clientInfo_bookID.Size = new Size(73, 23);
            clientInfo_bookID.TabIndex = 11;
            clientInfo_bookID.Text = "Book ID";
            // 
            // clientInfo_name
            // 
            clientInfo_name.Font = new Font("Source Code Pro", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clientInfo_name.Location = new Point(218, 150);
            clientInfo_name.Name = "clientInfo_name";
            clientInfo_name.Size = new Size(191, 30);
            clientInfo_name.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(61, 64, 91);
            label8.Location = new Point(99, 157);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 8;
            label8.Text = "Full Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(61, 64, 91);
            label7.Location = new Point(63, 208);
            label7.Name = "label7";
            label7.Size = new Size(136, 23);
            label7.TabIndex = 7;
            label7.Text = "Email Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 64, 91);
            label1.Location = new Point(99, 108);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 2;
            label1.Text = "Book ID:";
            // 
            // clientInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 222);
            ClientSize = new Size(961, 616);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "clientInfo";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label close;
        private Panel panel2;
        private Label label1;
        private Label label8;
        private Label label7;
        private ComboBox clientInfo_gender;
        private Label label5;
        private TextBox clientInfo_contactNum;
        private Label label4;
        private TextBox clientInfo_email;
        private Label clientInfo_bookID;
        private TextBox clientInfo_name;
        private Button clientInfo_clearBtn;
        private Button clientInfo_bookBtn;
    }
}