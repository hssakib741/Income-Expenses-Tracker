namespace IncomeAndExpenseTracker
{
    partial class MainFrom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardFrom1 = new IncomeAndExpenseTracker.DashboardFrom();
            this.categoryForm1 = new IncomeAndExpenseTracker.CategoryForm();
            this.expenseForm1 = new IncomeAndExpenseTracker.ExpenseForm();
            this.incomeForm1 = new IncomeAndExpenseTracker.IncomeForm();
            this.logout_Btn = new System.Windows.Forms.Button();
            this.expense_btn = new System.Windows.Forms.Button();
            this.income_Btn = new System.Windows.Forms.Button();
            this.addCategory_Btn = new System.Windows.Forms.Button();
            this.dashboard_Btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 45);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Income & Expense Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1241, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 23);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.logout_Btn);
            this.panel2.Controls.Add(this.expense_btn);
            this.panel2.Controls.Add(this.income_Btn);
            this.panel2.Controls.Add(this.addCategory_Btn);
            this.panel2.Controls.Add(this.dashboard_Btn);
            this.panel2.Controls.Add(this.user);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 777);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(12, 182);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(92, 24);
            this.user.TabIndex = 1;
            this.user.Text = "Welcome";
            this.user.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboardFrom1);
            this.panel3.Controls.Add(this.categoryForm1);
            this.panel3.Controls.Add(this.expenseForm1);
            this.panel3.Controls.Add(this.incomeForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(234, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 777);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dashboardFrom1
            // 
            this.dashboardFrom1.Location = new System.Drawing.Point(3, 6);
            this.dashboardFrom1.Name = "dashboardFrom1";
            this.dashboardFrom1.Size = new System.Drawing.Size(1041, 777);
            this.dashboardFrom1.TabIndex = 4;
            this.dashboardFrom1.Load += new System.EventHandler(this.dashboardFrom1_Load);
            // 
            // categoryForm1
            // 
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(1041, 777);
            this.categoryForm1.TabIndex = 3;
            // 
            // expenseForm1
            // 
            this.expenseForm1.Location = new System.Drawing.Point(0, 0);
            this.expenseForm1.Name = "expenseForm1";
            this.expenseForm1.Size = new System.Drawing.Size(1041, 777);
            this.expenseForm1.TabIndex = 1;
            this.expenseForm1.Tag = "";
            // 
            // incomeForm1
            // 
            this.incomeForm1.Location = new System.Drawing.Point(0, 0);
            this.incomeForm1.Name = "incomeForm1";
            this.incomeForm1.Size = new System.Drawing.Size(1041, 777);
            this.incomeForm1.TabIndex = 0;
            this.incomeForm1.Load += new System.EventHandler(this.incomeForm1_Load);
            // 
            // logout_Btn
            // 
            this.logout_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.logout_Btn.FlatAppearance.BorderSize = 0;
            this.logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Btn.Image = global::IncomeAndExpenseTracker.Properties.Resources.logout;
            this.logout_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_Btn.Location = new System.Drawing.Point(16, 725);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(201, 40);
            this.logout_Btn.TabIndex = 6;
            this.logout_Btn.Text = "Log Out";
            this.logout_Btn.UseVisualStyleBackColor = false;
            this.logout_Btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // expense_btn
            // 
            this.expense_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expense_btn.FlatAppearance.BorderSize = 0;
            this.expense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense_btn.Image = global::IncomeAndExpenseTracker.Properties.Resources.expenses;
            this.expense_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expense_btn.Location = new System.Drawing.Point(16, 454);
            this.expense_btn.Name = "expense_btn";
            this.expense_btn.Size = new System.Drawing.Size(201, 40);
            this.expense_btn.TabIndex = 5;
            this.expense_btn.Text = "Expenses";
            this.expense_btn.UseVisualStyleBackColor = false;
            this.expense_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // income_Btn
            // 
            this.income_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_Btn.FlatAppearance.BorderSize = 0;
            this.income_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_Btn.Image = global::IncomeAndExpenseTracker.Properties.Resources.income;
            this.income_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income_Btn.Location = new System.Drawing.Point(16, 386);
            this.income_Btn.Name = "income_Btn";
            this.income_Btn.Size = new System.Drawing.Size(201, 40);
            this.income_Btn.TabIndex = 4;
            this.income_Btn.Text = "Income";
            this.income_Btn.UseVisualStyleBackColor = false;
            this.income_Btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // addCategory_Btn
            // 
            this.addCategory_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.addCategory_Btn.FlatAppearance.BorderSize = 0;
            this.addCategory_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory_Btn.Image = global::IncomeAndExpenseTracker.Properties.Resources.category;
            this.addCategory_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategory_Btn.Location = new System.Drawing.Point(16, 316);
            this.addCategory_Btn.Name = "addCategory_Btn";
            this.addCategory_Btn.Size = new System.Drawing.Size(201, 40);
            this.addCategory_Btn.TabIndex = 3;
            this.addCategory_Btn.Text = "Add Category";
            this.addCategory_Btn.UseVisualStyleBackColor = false;
            this.addCategory_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboard_Btn
            // 
            this.dashboard_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.dashboard_Btn.FlatAppearance.BorderSize = 0;
            this.dashboard_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_Btn.Image = global::IncomeAndExpenseTracker.Properties.Resources.layout;
            this.dashboard_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_Btn.Location = new System.Drawing.Point(16, 240);
            this.dashboard_Btn.Name = "dashboard_Btn";
            this.dashboard_Btn.Size = new System.Drawing.Size(201, 40);
            this.dashboard_Btn.TabIndex = 2;
            this.dashboard_Btn.Text = "Dashboard";
            this.dashboard_Btn.UseVisualStyleBackColor = false;
            this.dashboard_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IncomeAndExpenseTracker.Properties.Resources.male;
            this.pictureBox2.Location = new System.Drawing.Point(62, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IncomeAndExpenseTracker.Properties.Resources.male;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1275, 822);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrom";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button dashboard_Btn;
        private System.Windows.Forms.Button expense_btn;
        private System.Windows.Forms.Button income_Btn;
        private System.Windows.Forms.Button addCategory_Btn;
        private System.Windows.Forms.Button logout_Btn;
        private System.Windows.Forms.Panel panel3;
        private IncomeForm incomeForm1;
        private ExpenseForm expenseForm1;
        private DashboardFrom dashboardFrom1;
        private CategoryForm categoryForm1;
    }
}