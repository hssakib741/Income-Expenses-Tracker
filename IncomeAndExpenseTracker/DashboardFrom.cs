using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace IncomeAndExpenseTracker
{
    public partial class DashboardFrom : UserControl
{
        string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public DashboardFrom()
        {
            InitializeComponent();
            incomeToday();
            incomeYesterday();
            incomeThisMonth();
            incomeThisYear();
            totalIncome();

            expenseToday();
            expenseYesterday();
            expenseThisMonth();
            expenseThisYear();
            totalexpense();
        }

        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
            }

            
            incomeToday();
            incomeYesterday();
            incomeThisMonth();
            incomeThisYear();
            totalIncome();

            expenseToday();
            expenseYesterday();
            expenseThisMonth();
            expenseThisYear();
            totalexpense();
        }

        //income start

        public void incomeToday()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string query = "SELECT SUM(income) FROM income WHERE date_income=@date_in";
            SqlCommand cmd = new SqlCommand(query, conn);
            DateTime today = DateTime.Today;
            cmd.Parameters.AddWithValue("date_in", today);

            object result = cmd.ExecuteScalar();
            if(result !=DBNull.Value)
            {
                decimal todayCost= Convert.ToDecimal(result);

                income_totalincome.Text = "$" + todayCost.ToString("0.00");
            }
            else
            {
                income_totalincome.Text = "$0.00";
            }
        }

        public void incomeYesterday()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string query = "SELECT SUM(income) FROM income WHERE date_income=@date_in";
            SqlCommand cmd = new SqlCommand(query, conn);

            
            DateTime yesterday = DateTime.Today.AddDays(-1);
            cmd.Parameters.AddWithValue("date_in", yesterday);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                decimal yesterdayCost = Convert.ToDecimal(result);
                income_yesterdayincome.Text = "$" + yesterdayCost.ToString("0.00"); 
            }
            else
            {
                income_yesterdayincome.Text = "$0.00";
            }
        }

        public void incomeThisMonth()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            DateTime today = DateTime.Now.Date;
            DateTime startMonth = new DateTime(today.Year, today.Month, 1);
            DateTime endMonth= startMonth.AddMonths(1).AddDays(-1);

            string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth";
            SqlCommand cmd = new SqlCommand(query, conn);           

            cmd.Parameters.AddWithValue("@startMonth", startMonth);
            cmd.Parameters.AddWithValue("@endMonth", endMonth);
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                decimal monthCost = Convert.ToDecimal(result);
                income_thisMonthincome.Text = "$" + monthCost.ToString("0.00"); 
            }
            else
            {
                income_thisMonthincome.Text = "$0.00";
            }

        }

        public void incomeThisYear()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            DateTime today = DateTime.Now.Date;
            DateTime startYear = new DateTime(today.Year, 1,1);
            DateTime endYear = startYear.AddYears(1).AddDays(-1);

            string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@startYear", startYear);
            cmd.Parameters.AddWithValue("@endYear", endYear);
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                decimal yearCost = Convert.ToDecimal(result);
                income_thisYearincome.Text = "$" + yearCost.ToString("0.00");
            }
            else
            {
                income_thisYearincome.Text = "$0.00";
            }
        }

        public void totalIncome()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string query = "SELECT SUM(income) FROM income";
            SqlCommand cmd = new SqlCommand(query, conn);
            

            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                decimal totalCost = Convert.ToDecimal(result);

                Total_income.Text = "$" + totalCost.ToString("0.00");
            }
            else
            {
                Total_income.Text = "$0.00";
            }
        }

        //income END

        //Expense Start

        public void expenseToday()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string query = "SELECT SUM(cost) FROM expenses WHERE date_expense=@date_expense";
            SqlCommand cmd = new SqlCommand(query, conn);
            DateTime today = DateTime.Today;
            cmd.Parameters.AddWithValue("date_expense", today);

            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                decimal todayCost = Convert.ToDecimal(result);

                expense_today.Text = "$" + todayCost.ToString("0.00");
            }
            else
            {
                expense_today.Text = "$0.00";
            }
        }

        public void expenseYesterday()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string query = "SELECT SUM(cost) FROM expenses WHERE date_expense=@date_expense";
            SqlCommand cmd = new SqlCommand(query, conn);


            DateTime yesterday = DateTime.Today.AddDays(-1);
            cmd.Parameters.AddWithValue("date_expense", yesterday);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                decimal yesterdayCost = Convert.ToDecimal(result);
                expense_yesterday.Text = "$" + yesterdayCost.ToString("0.00");
            }
            else
            {
                expense_yesterday.Text = "$0.00";
            }
        }

        public void expenseThisMonth()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            DateTime today = DateTime.Now.Date;
            DateTime startMonth = new DateTime(today.Year, today.Month, 1);
            DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

            string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@startMonth", startMonth);
            cmd.Parameters.AddWithValue("@endMonth", endMonth);
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                decimal monthCost = Convert.ToDecimal(result);
                expense_thisMonth.Text = "$" + monthCost.ToString("0.00");
            }
            else
            {
                expense_thisMonth.Text = "$0.00";
            }

        }

        public void expenseThisYear()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            DateTime today = DateTime.Now.Date;
            DateTime startYear = new DateTime(today.Year, 1, 1);
            DateTime endYear = startYear.AddYears(1).AddDays(-1);

            string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@startYear", startYear);
            cmd.Parameters.AddWithValue("@endYear", endYear);
            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                decimal yearCost = Convert.ToDecimal(result);
                expense_thisYear.Text = "$" + yearCost.ToString("0.00");
            }
            else
            {
                expense_thisYear.Text = "$0.00";
            }
        }

        public void totalexpense()
        {
            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string query = "SELECT SUM(cost) FROM expenses";
            SqlCommand cmd = new SqlCommand(query, conn);


            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                decimal totalCost = Convert.ToDecimal(result);

                Total_expenses.Text = "$" + totalCost.ToString("0.00");
            }
            else
            {
                Total_expenses.Text = "$0.00";
            }
        }
        private void DashboardFrom_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void income_thisMonthincome_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void expense_thisYear_Click(object sender, EventArgs e)
        {

        }

        private void expense_yesterday_Click(object sender, EventArgs e)
        {

        }

        private void expense_today_Click(object sender, EventArgs e)
        {

        }

        private void expense_thisMonth_Click(object sender, EventArgs e)
        {

        }
    }
}
