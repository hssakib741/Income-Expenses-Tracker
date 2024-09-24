using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IncomeAndExpenseTracker
{
    public partial class AdminMain : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminMain()
        {
            InitializeComponent();
            LoadUserData();  
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            
            LoadUserData();
           

        }

        
        private void LoadUserData()
        {
            try
            {
                conn.Open();

                
                string query = @"
                    SELECT 
                        u.id AS [User ID], 
                        u.username AS [Username], 
                        ISNULL(SUM(i.income), 0) AS [Total Income],
                        ISNULL(SUM(e.cost), 0) AS [Total Expense]
                    FROM users u
                    LEFT JOIN income i ON u.id = i.id
                    LEFT JOIN expenses e ON u.id = e.id
                    GROUP BY u.id, u.username";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                userDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void createUserButton_Click(object sender, EventArgs e)
        {
            RegisterFrom registerForm = new RegisterFrom();

            if (registerForm.ShowDialog() == DialogResult.OK) // If registration was successful
            {
                LoadUserData(); // Reload the user data
            }
        }




        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            
            if (userDataGridView.SelectedRows.Count == 0)
            {
                
                MessageBox.Show("Please Select a User", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this user and all their data?",
                    "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    try
                    {
                        
                        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
                        conn.Open();

                        
                        int userId = Convert.ToInt32(userDataGridView.SelectedRows[0].Cells["User ID"].Value);

                        
                        string deleteUser = "DELETE FROM users WHERE id=@userId";
                        SqlCommand cmd = new SqlCommand(deleteUser, conn);

                        
                        cmd.Parameters.AddWithValue("@userId", userId);

                        
                        cmd.ExecuteNonQuery();

                        
                        MessageBox.Show("User deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        userDataGridView.ClearSelection();
                        LoadUserData();

                        
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void createUserButton_Click_1(object sender, EventArgs e)
        {
            createUserButton_Click(sender,e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteUserButton_Click_1(object sender, EventArgs e)
        {
            deleteUserButton_Click(sender, e);
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to LogOut", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
