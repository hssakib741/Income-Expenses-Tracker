namespace IncomeAndExpenseTracker
{
    partial class IncomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.income_clearBtn = new System.Windows.Forms.Button();
            this.income_deleteBtn = new System.Windows.Forms.Button();
            this.income_updateBtn = new System.Windows.Forms.Button();
            this.income_addBtn = new System.Windows.Forms.Button();
            this.income_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.income_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.income_income = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.income_item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(15, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 355);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.income_clearBtn);
            this.panel2.Controls.Add(this.income_deleteBtn);
            this.panel2.Controls.Add(this.income_updateBtn);
            this.panel2.Controls.Add(this.income_addBtn);
            this.panel2.Controls.Add(this.income_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.income_description);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.income_income);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.income_item);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.income_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 355);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // income_clearBtn
            // 
            this.income_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_clearBtn.FlatAppearance.BorderSize = 0;
            this.income_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_clearBtn.ForeColor = System.Drawing.Color.White;
            this.income_clearBtn.Location = new System.Drawing.Point(677, 262);
            this.income_clearBtn.Name = "income_clearBtn";
            this.income_clearBtn.Size = new System.Drawing.Size(97, 43);
            this.income_clearBtn.TabIndex = 14;
            this.income_clearBtn.Text = "Clear";
            this.income_clearBtn.UseVisualStyleBackColor = false;
            this.income_clearBtn.Click += new System.EventHandler(this.income_clearBtn_Click);
            // 
            // income_deleteBtn
            // 
            this.income_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_deleteBtn.FlatAppearance.BorderSize = 0;
            this.income_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.income_deleteBtn.Location = new System.Drawing.Point(516, 262);
            this.income_deleteBtn.Name = "income_deleteBtn";
            this.income_deleteBtn.Size = new System.Drawing.Size(97, 43);
            this.income_deleteBtn.TabIndex = 13;
            this.income_deleteBtn.Text = "Delete";
            this.income_deleteBtn.UseVisualStyleBackColor = false;
            this.income_deleteBtn.Click += new System.EventHandler(this.income_deleteBtn_Click);
            // 
            // income_updateBtn
            // 
            this.income_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_updateBtn.FlatAppearance.BorderSize = 0;
            this.income_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_updateBtn.ForeColor = System.Drawing.Color.White;
            this.income_updateBtn.Location = new System.Drawing.Point(373, 262);
            this.income_updateBtn.Name = "income_updateBtn";
            this.income_updateBtn.Size = new System.Drawing.Size(97, 43);
            this.income_updateBtn.TabIndex = 12;
            this.income_updateBtn.Text = "Update";
            this.income_updateBtn.UseVisualStyleBackColor = false;
            this.income_updateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // income_addBtn
            // 
            this.income_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_addBtn.FlatAppearance.BorderSize = 0;
            this.income_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_addBtn.ForeColor = System.Drawing.Color.White;
            this.income_addBtn.Location = new System.Drawing.Point(212, 262);
            this.income_addBtn.Name = "income_addBtn";
            this.income_addBtn.Size = new System.Drawing.Size(97, 43);
            this.income_addBtn.TabIndex = 11;
            this.income_addBtn.Text = "Add";
            this.income_addBtn.UseVisualStyleBackColor = false;
            this.income_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // income_date
            // 
            this.income_date.Location = new System.Drawing.Point(570, 166);
            this.income_date.Name = "income_date";
            this.income_date.Size = new System.Drawing.Size(247, 22);
            this.income_date.TabIndex = 10;
            this.income_date.ValueChanged += new System.EventHandler(this.income_date_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // income_description
            // 
            this.income_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_description.Location = new System.Drawing.Point(570, 34);
            this.income_description.Multiline = true;
            this.income_description.Name = "income_description";
            this.income_description.Size = new System.Drawing.Size(411, 94);
            this.income_description.TabIndex = 8;
            this.income_description.TextChanged += new System.EventHandler(this.income_description_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // income_income
            // 
            this.income_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_income.Location = new System.Drawing.Point(175, 167);
            this.income_income.Name = "income_income";
            this.income_income.Size = new System.Drawing.Size(219, 27);
            this.income_income.TabIndex = 6;
            this.income_income.TextChanged += new System.EventHandler(this.income_income_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Income:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // income_item
            // 
            this.income_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_item.Location = new System.Drawing.Point(172, 101);
            this.income_item.Name = "income_item";
            this.income_item.Size = new System.Drawing.Size(222, 27);
            this.income_item.TabIndex = 4;
            this.income_item.TextChanged += new System.EventHandler(this.income_item_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // income_category
            // 
            this.income_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_category.FormattingEnabled = true;
            this.income_category.Items.AddRange(new object[] {
            "Allowance",
            "Scholarship"});
            this.income_category.Location = new System.Drawing.Point(175, 33);
            this.income_category.Name = "income_category";
            this.income_category.Size = new System.Drawing.Size(219, 28);
            this.income_category.TabIndex = 2;
            this.income_category.SelectedIndexChanged += new System.EventHandler(this.income_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Size = new System.Drawing.Size(1041, 777);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox income_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox income_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox income_income;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox income_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button income_clearBtn;
        private System.Windows.Forms.Button income_deleteBtn;
        private System.Windows.Forms.Button income_updateBtn;
        private System.Windows.Forms.Button income_addBtn;
    }
}
