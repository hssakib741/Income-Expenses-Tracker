namespace IncomeAndExpenseTracker
{
    partial class AdminRegisterForm
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
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admin_login_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_cpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_showpass = new System.Windows.Forms.CheckBox();
            this.admin_btn = new System.Windows.Forms.Button();
            this.admin_password_tb = new System.Windows.Forms.TextBox();
            this.admin_username_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(736, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.TabIndex = 19;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.admin_login_btn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 563);
            this.panel1.TabIndex = 20;
            // 
            // admin_login_btn
            // 
            this.admin_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.admin_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_login_btn.ForeColor = System.Drawing.Color.White;
            this.admin_login_btn.Location = new System.Drawing.Point(87, 482);
            this.admin_login_btn.Name = "admin_login_btn";
            this.admin_login_btn.Size = new System.Drawing.Size(210, 40);
            this.admin_login_btn.TabIndex = 7;
            this.admin_login_btn.Text = "Sign In";
            this.admin_login_btn.UseVisualStyleBackColor = false;
            this.admin_login_btn.Click += new System.EventHandler(this.admin_login_btn_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(122, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "SIGN IN HERE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income & Expense Tracker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IncomeAndExpenseTracker.Properties.Resources.male;
            this.pictureBox1.Location = new System.Drawing.Point(116, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // admin_cpassword
            // 
            this.admin_cpassword.Location = new System.Drawing.Point(432, 423);
            this.admin_cpassword.Multiline = true;
            this.admin_cpassword.Name = "admin_cpassword";
            this.admin_cpassword.PasswordChar = '*';
            this.admin_cpassword.Size = new System.Drawing.Size(291, 34);
            this.admin_cpassword.TabIndex = 29;
            this.admin_cpassword.TextChanged += new System.EventHandler(this.admin_cpassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Confirm Password";
            // 
            // admin_showpass
            // 
            this.admin_showpass.AutoSize = true;
            this.admin_showpass.BackColor = System.Drawing.Color.Transparent;
            this.admin_showpass.Location = new System.Drawing.Point(598, 476);
            this.admin_showpass.Name = "admin_showpass";
            this.admin_showpass.Size = new System.Drawing.Size(125, 20);
            this.admin_showpass.TabIndex = 27;
            this.admin_showpass.Text = "Show Password";
            this.admin_showpass.UseVisualStyleBackColor = false;
            this.admin_showpass.CheckedChanged += new System.EventHandler(this.admin_showpass_CheckedChanged_1);
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.admin_btn.ForeColor = System.Drawing.Color.White;
            this.admin_btn.Location = new System.Drawing.Point(432, 494);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(96, 40);
            this.admin_btn.TabIndex = 26;
            this.admin_btn.Text = "Sign Up";
            this.admin_btn.UseVisualStyleBackColor = false;
            // 
            // admin_password_tb
            // 
            this.admin_password_tb.Location = new System.Drawing.Point(432, 316);
            this.admin_password_tb.Multiline = true;
            this.admin_password_tb.Name = "admin_password_tb";
            this.admin_password_tb.PasswordChar = '*';
            this.admin_password_tb.Size = new System.Drawing.Size(291, 34);
            this.admin_password_tb.TabIndex = 25;
            // 
            // admin_username_tb
            // 
            this.admin_username_tb.Location = new System.Drawing.Point(432, 213);
            this.admin_username_tb.Multiline = true;
            this.admin_username_tb.Name = "admin_username_tb";
            this.admin_username_tb.Size = new System.Drawing.Size(291, 34);
            this.admin_username_tb.TabIndex = 24;
            this.admin_username_tb.TextChanged += new System.EventHandler(this.admin_username_tb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "REGISTER AS ADMIN";
            // 
            // AdminRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 563);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.admin_cpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_showpass);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.admin_password_tb);
            this.Controls.Add(this.admin_username_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminRegisterForm";
            this.Text = "AdminRegisterForm";
            this.Load += new System.EventHandler(this.AdminRegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin_login_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox admin_cpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox admin_showpass;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.TextBox admin_password_tb;
        private System.Windows.Forms.TextBox admin_username_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}