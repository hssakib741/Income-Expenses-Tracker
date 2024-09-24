using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IncomeAndExpenseTracker
{
    public partial class AdminRegisterForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminRegisterForm()
        {
            InitializeComponent();
            admin_btn.Click += new EventHandler(admin_btn_Click); // Changed from register_btn to admin_btn
        }

        public bool checkConnection()
        {
            return (conn.State == ConnectionState.Closed) ? true : false;
        }

        private void admin_btn_Click(object sender, EventArgs e) // Changed from register_btn_Click to admin_btn_Click
        {
            if (admin_username_tb.Text == "" || admin_password_tb.Text == "" || admin_cpassword.Text == "") // Updated control names
            {
                MessageBox.Show("Please Fill All Blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        conn.Open();

                        // Check if admin username is already registered
                        string selectAdminUsername = "SELECT * FROM admin_users WHERE admin_username=@adminUsern";
                        using (SqlCommand checkAdminUser = new SqlCommand(selectAdminUsername, conn))
                        {
                            checkAdminUser.Parameters.AddWithValue("@adminUsern", admin_username_tb.Text.Trim()); // Updated control name

                            SqlDataAdapter adapter = new SqlDataAdapter(checkAdminUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                // Capitalize the first letter of the admin username
                                string tempUsern = admin_username_tb.Text.Substring(0, 1).ToUpper() + admin_username_tb.Text.Substring(1); // Updated control name
                                MessageBox.Show(tempUsern + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (admin_password_tb.Text.Length < 8) // Updated control name
                            {
                                MessageBox.Show("Invalid Password, At Least 8 Characters Needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (admin_password_tb.Text != admin_cpassword.Text) // Updated control name
                            {
                                MessageBox.Show("Passwords Do Not Match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Insert the new admin data into the admin_users table
                                string insertAdminData = "INSERT INTO admin_users (admin_username, admin_password, date_created) VALUES (@adminUsern, @adminPass, @date)";
                                using (SqlCommand insertAdminUser = new SqlCommand(insertAdminData, conn))
                                {
                                    insertAdminUser.Parameters.AddWithValue("@adminUsern", admin_username_tb.Text.Trim()); // Updated control name
                                    insertAdminUser.Parameters.AddWithValue("@adminPass", admin_password_tb.Text.Trim()); // Updated control name
                                    insertAdminUser.Parameters.AddWithValue("@date", DateTime.Today);

                                    insertAdminUser.ExecuteNonQuery();
                                    MessageBox.Show("Admin Registered Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
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
            }
        }

        private void AdminRegisterForm_Load(object sender, EventArgs e) { }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_login_btn_Click(object sender, EventArgs e) 
        {
            Form1 loginFrom = new Form1();
            loginFrom.Show();
            this.Hide();
        }

        private void admin_showpass_CheckedChanged(object sender, EventArgs e) 
        {
            admin_password_tb.PasswordChar = admin_showpass.Checked ? '\0' : '*'; 
            admin_cpassword.PasswordChar = admin_showpass.Checked ? '\0' : '*'; 
        }

        private void admin_username_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_cpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_showpass_CheckedChanged_1(object sender, EventArgs e)
        {
            admin_password_tb.PasswordChar = admin_showpass.Checked ? '\0' : '*';
        }

        private void admin_login_btn_Click_1(object sender, EventArgs e)
        {
            Form1 loginFrom = new Form1();
            loginFrom.Show();
            this.Hide();
        }
    }
}
