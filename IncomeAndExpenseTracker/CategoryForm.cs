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
    public partial class CategoryForm : UserControl
    {
        string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public CategoryForm()
        {
            InitializeComponent();
            displayCategoryList();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
            }

            
            displayCategoryList();
        }

        public void displayCategoryList()
        {
            CategoryData data = new CategoryData();
            List<CategoryData> listData = data.categoryListData();

            dataGridView1.DataSource = listData;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
            
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void category_addBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_status.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill All Blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection conn = new SqlConnection(stringConn);
                conn.Open();

                string inserData = "INSERT INTO categories(category,type,status,date_insert)" + "VALUES (@cat,@type,@status,@date)";

                SqlCommand cmd = new SqlCommand(inserData, conn);

                cmd.Parameters.AddWithValue("@cat", category_category.Text.Trim());
                cmd.Parameters.AddWithValue("@type", category_type.SelectedItem);
                cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);

                DateTime today = DateTime.Today;
                cmd.Parameters.AddWithValue("@date", today);
                cmd.ExecuteNonQuery();
                clearFields();

                MessageBox.Show("Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            displayCategoryList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                category_category.Text = row.Cells[1].Value.ToString();
                category_type.SelectedItem = row.Cells[2].Value.ToString();
                category_status.SelectedItem = row.Cells[3].Value.ToString();


            }
        }

        private void category_updateBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_status.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Item First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string message = "Are You Sure You Want To Upgrade ID " + getID + "?";
                if (MessageBox.Show(message, "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlConnection conn = new SqlConnection(stringConn);
                    conn.Open();

                    string updateData = "UPDATE categories SET category =@cat,type=@type,status=@status WHERE id=@id";

                SqlCommand cmd = new SqlCommand(updateData, conn);

                    cmd.Parameters.AddWithValue("@id", getID);
                    cmd.Parameters.AddWithValue("@cat", category_category.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", category_type.SelectedItem);
                    cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);

                   
                    cmd.ExecuteNonQuery();
                    clearFields();

                    MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
               
            }
            displayCategoryList();
        }

        public void clearFields()
        {
            category_category.Text = "";
            category_type.SelectedIndex = -1;
            category_status.SelectedIndex = -1;
        }
        private void category_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void category_deleteBtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_status.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Item First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string message = "Are You Sure You Want To Delete ID " + getID + "?";
                if (MessageBox.Show(message, "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlConnection conn = new SqlConnection(stringConn);
                    conn.Open();

                    string updateData = "DELETE FROM categories WHERE id=@id";

                    SqlCommand cmd = new SqlCommand(updateData, conn);

                    cmd.Parameters.AddWithValue("@id", getID);
                   


                    cmd.ExecuteNonQuery();
                    clearFields();

                    MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }

            }
            displayCategoryList();
        }

        private void category_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
