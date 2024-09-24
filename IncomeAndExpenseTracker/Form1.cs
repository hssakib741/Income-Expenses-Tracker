using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IncomeAndExpenseTracker
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static string username;

        // Event handler for the login button click
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string selectData;
            if (radioClient.Checked)  // If client radio button is checked
            {
                selectData = "SELECT * FROM users WHERE username =@usern AND password =@pass";
            }
            else if (radioAdmin.Checked)  // If admin radio button is checked
            {
                selectData = "SELECT * FROM admin_users WHERE admin_username =@usern AND admin_password =@pass";
            }
            else
            {
                MessageBox.Show("Please select login type (Client or Admin)", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }

            using (SqlCommand cmd = new SqlCommand(selectData, conn))
            {
                cmd.Parameters.AddWithValue("@usern", login_username_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", login_password_tb.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = login_username_tb.Text;
                    MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (radioClient.Checked)
                    {
                        MainFrom mainForm = new MainFrom();  // Redirect to Main form for client
                        mainForm.Show();
                    }
                    else
                    {
                        AdminMain adminMain = new AdminMain();  // Redirect to Admin Dashboard for admin
                        adminMain.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            conn.Close();
        }

        private void login_username_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_signup_Click(object sender, EventArgs e)
        {
            RegisterFrom registerForm = new RegisterFrom();
            registerForm.Show();
            this.Hide();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password_tb.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminRegisterForm adminRegisterForm = new AdminRegisterForm();
            adminRegisterForm.Show();
            this.Hide();
        }
    }
}
