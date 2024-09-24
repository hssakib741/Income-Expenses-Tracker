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
    public partial class ExpenseForm : UserControl
    {
        string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public ExpenseForm()
        {
            InitializeComponent();
            DisplaycategoryList();
            displayExpenseData();
            
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
            }

            DisplaycategoryList();
            displayExpenseData();
        }
        public void displayExpenseData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expenseListData();

            dataGridView1.DataSource = listData;
        }

        public void DisplaycategoryList()
        {

            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string selectData = "SELECT category FROM categories WHERE type= @type AND status =@status";

            SqlCommand cmd = new SqlCommand(selectData, conn);

            cmd.Parameters.AddWithValue("@type", "Expenses");
            cmd.Parameters.AddWithValue("@status", "Active");

            //income_category.Items.Clear();
            

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                expense_category.Items.Add(reader["category"].ToString());
            }

        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {

        }

        private void income_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void expense_addBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_cost.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please Fill All Blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                SqlConnection conn = new SqlConnection(stringConn);
                conn.Open();

                string insertData = "INSERT INTO expenses (category,item,cost,description,date_expense,date_insert)"+ "VALUES (@cat,@item,@cost,@desc,@date_ex,@date)";
                SqlCommand cmd = new SqlCommand(insertData, conn); //

                cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                cmd.Parameters.AddWithValue("@item", expense_item.Text);
                cmd.Parameters.AddWithValue("@cost", expense_cost.Text);
                cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                cmd.Parameters.AddWithValue("@date_ex", expense_date.Value);


                DateTime today = DateTime.Today;
                cmd.Parameters.AddWithValue("@date", today);
                cmd.ExecuteNonQuery();
                clearFields();

                MessageBox.Show("Addes Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();


            }
            displayExpenseData();
        }

        public void clearFields()
        {
            expense_item.Text = "";
            expense_category.SelectedIndex = -1;
            expense_cost.Text = "";
            expense_description.Text = "";
            
        }

        private void expense_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void expense_updateBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_cost.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please Select Item ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                SqlConnection conn = new SqlConnection(stringConn);
                conn.Open();

                string updateData = "UPDATE expenses SET category=@cat,item =@item,cost=@cost,description=@desc,date_expense=@date_ex WHERE id=@id";
                SqlCommand cmd = new SqlCommand(updateData, conn); 

                cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                cmd.Parameters.AddWithValue("@item", expense_item.Text);
                cmd.Parameters.AddWithValue("@cost", expense_cost.Text);
                cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                cmd.Parameters.AddWithValue("@date_ex", expense_date.Value);
                cmd.Parameters.AddWithValue("@id", getID);


                DateTime today = DateTime.Today;
                cmd.Parameters.AddWithValue("@date", today);
                cmd.ExecuteNonQuery();
                clearFields();

                MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();


            }
            displayExpenseData();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                expense_category.SelectedItem = row.Cells[1].Value.ToString();
                expense_item.Text = row.Cells[2].Value.ToString();
                expense_cost.Text = row.Cells[3].Value.ToString();
                expense_description.Text = row.Cells[4].Value.ToString();
                //   expense_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());

                DateTime expenseDate;
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out expenseDate))
                {
                    expense_date.Value = expenseDate;
                }
                else
                {
                    MessageBox.Show("Invalid date format in the selected row.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void expense_deleteBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_cost.Text == "" || expense_description.Text == "")
            {
                MessageBox.Show("Please Select Item ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                SqlConnection conn = new SqlConnection(stringConn);
                conn.Open();

                string deleteData = "DELETE FROM expenses WHERE id=@id";
                SqlCommand cmd = new SqlCommand(deleteData, conn);

              
                cmd.Parameters.AddWithValue("@id", getID);

                cmd.ExecuteNonQuery();
                clearFields();

                MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();


            }
            displayExpenseData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
