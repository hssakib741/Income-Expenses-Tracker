using System;
using IncomeAndExpenseTracker;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeAndExpenseTracker
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
            displayUserName();

        }

        public void displayUserName()
        { 
            string getUserName= Form1.username;
            user.Text= "Welcome, "+getUserName;

    }

        private void MainFrom_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to LogOut", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardFrom1.Visible=true;
            categoryForm1.Visible = false;
            incomeForm1.Visible=false;
            expenseForm1.Visible=false;

            DashboardFrom dFrom= dashboardFrom1 as DashboardFrom;

            if(dFrom !=null)
            {
                dFrom.refreshData();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboardFrom1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;

            CategoryForm cFrom = categoryForm1 as CategoryForm;

            if (cFrom != null)
            {
                cFrom.refreshData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboardFrom1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expenseForm1.Visible = false;

            IncomeForm iFrom = incomeForm1 as IncomeForm;

            if (iFrom != null)
            {
                iFrom.refreshData();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to LogOut", "Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dashboardFrom1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = true;

            ExpenseForm eFrom = expenseForm1 as ExpenseForm;

            if (eFrom != null)
            {
                eFrom.refreshData();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void categoryForm1_Load(object sender, EventArgs e)
        {

        }

        private void incomeForm1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardFrom1_Load(object sender, EventArgs e)
        {

        }
    }
}
