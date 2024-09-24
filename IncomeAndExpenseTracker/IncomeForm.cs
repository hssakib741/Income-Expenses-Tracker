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
    public partial class IncomeForm : UserControl
    {
        string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public IncomeForm()
        {
            InitializeComponent();

            displayCategoryList();
            displayIncomeData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
            }

            displayCategoryList();
            displayIncomeData();
        }
        public void displayIncomeData()
        {
            IncomeData iData=new IncomeData();
            List<IncomeData> listData = iData.incomeListData();

            dataGridView1.DataSource= listData;
        }
        public void displayCategoryList()
        {

            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string selectData = "SELECT category FROM categories WHERE type='Income' AND status='Active';\r\n";

            SqlCommand cmd = new SqlCommand(selectData, conn);

            cmd.Parameters.AddWithValue("@type", "Income");
            cmd.Parameters.AddWithValue("@status", "Active");

            //income_category.Items.Clear();
            

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                income_category.Items.Add(reader["category"].ToString());
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please Select Item First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                SqlConnection conn = new SqlConnection(stringConn);
                conn.Open();

                string updateData = "UPDATE income SET category =@cat,item=@item,income=@income,description=@desc,date_income=@date_in Where id=@id";
                SqlCommand cmd = new SqlCommand(updateData, conn);

                cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                cmd.Parameters.AddWithValue("@item", income_item.Text);
                cmd.Parameters.AddWithValue("@income", income_income.Text);
                cmd.Parameters.AddWithValue("@desc", income_description.Text);
                cmd.Parameters.AddWithValue("@date_in", income_date.Value);
                cmd.Parameters.AddWithValue("@id", getID);


                cmd.ExecuteNonQuery();
                clearFields();

                MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();


            }
            displayIncomeData();
        }

        private void income_addBtn_Click(object sender, EventArgs e)
        {
            if(income_category.SelectedIndex==-1 || income_item.Text=="" || income_income.Text==""|| income_description.Text=="")
            {
                MessageBox.Show("Please Fill All Blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                    SqlConnection conn=new SqlConnection(stringConn);
                    conn.Open();

                string insertData = "INSERT INTO income (category,item,income,description,date_income,date_insert)" + "VALUES (@cat,@item,@income,@desc,@data_in,@data)";
                SqlCommand cmd = new SqlCommand(insertData, conn);

                cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                cmd.Parameters.AddWithValue("@item", income_item.Text);
                cmd.Parameters.AddWithValue("@income", income_income.Text);
                cmd.Parameters.AddWithValue("@desc", income_description.Text);
                cmd.Parameters.AddWithValue("@data_in", income_date.Value);
                

                DateTime today = DateTime.Today;
                cmd.Parameters.AddWithValue("@data", today);
                cmd.ExecuteNonQuery();
                clearFields();

                MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();


            }
            displayIncomeData();
        }

       
        public void clearFields()
        {
            income_item.Text = "";
            income_category.SelectedIndex = -1;
            income_income.Text = "";
            income_description.Text = "";
        }
        private void income_clearBtn_Click(object sender, EventArgs e)
        {

        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID=(int)row.Cells[0].Value;

                income_category.SelectedItem = row.Cells[1].Value.ToString();
                income_item.Text=row.Cells[2].Value.ToString();
                income_income.Text = row.Cells[3].Value.ToString();
                income_description.Text = row.Cells[4].Value.ToString();
                //   income_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());

                DateTime incomeDate;
                if (DateTime.TryParse(row.Cells[5].Value.ToString(), out incomeDate))
                {
                    income_date.Value = incomeDate;
                }
                else
                {
                    MessageBox.Show("Invalid date format in the selected row.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void income_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void income_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void income_deleteBtn_Click(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_income.Text == "" || income_description.Text == "")
            {
                MessageBox.Show("Please Select Item First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                if(MessageBox.Show("Are You Sure You Want to Delete ?"+getID+"?","Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(stringConn);
                    conn.Open();

                    string deleteData = "DELETE FROM income WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(deleteData, conn);


                    cmd.Parameters.AddWithValue("@id", getID);


                    cmd.ExecuteNonQuery();
                    clearFields();

                    MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn.Close();
                }
                


            }
            displayIncomeData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void income_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void income_income_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void income_item_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
