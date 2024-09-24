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
    public partial class RegisterFrom : Form
    {
        SqlConnection conn =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterFrom()
        {
            InitializeComponent();
            register_btn.Click += new EventHandler(register_btn_Click); // Ensure this line exists

        }

        public bool checkConnection()
        { 
            return (conn.State==ConnectionState.Closed)? true: false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (register_username_tb.Text == "" || register_password_tb.Text == "" || register_cpassword.Text == "")
            {
                MessageBox.Show("Please Fill All Blank Field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                if(checkConnection())
                {
                    try
                    {
                        conn.Open();
                        

                        //check username already register
                        string selectUserName = " SELECT * FROM users WHERE username=@usern";

                        using(SqlCommand checkUser = new SqlCommand(selectUserName,conn)) 
                            {
                            checkUser.Parameters.AddWithValue("@usern",register_username_tb.Text.Trim());

                            SqlDataAdapter adapter= new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);
                            if(table.Rows.Count != 0)
                            {
                                //First letter to Big
                                string tempUsern = register_username_tb.Text.Substring(0, 1).ToUpper() + register_username_tb.Text.Substring(1);
                                MessageBox.Show(tempUsern+ "Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }else if (register_password_tb.Text.Length<8)
                            { 
                                MessageBox.Show("Invalid Password At Least 8 Characters Needed", "Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error );
                            }else if(register_password_tb.Text != register_cpassword.Text)
                            {
                                MessageBox.Show("Password Does Not Match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username,password,date_create) VALUES (@usern,@pass,@date)";

                                using(SqlCommand insertUser = new SqlCommand(insertData,conn))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", register_username_tb.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", register_password_tb.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date", today);

                                    insertUser.ExecuteNonQuery();
                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm= new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        
                        }

                    }catch(Exception ex)
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

        private void RegisterFrom_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void register_login_btn_Click(object sender, EventArgs e)
        {
            Form1 loginFrom= new Form1();
            loginFrom.Show();
            this.Hide();
            
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            login_btn_Click(sender, e); 

        }

        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_password_tb.PasswordChar = register_showpass.Checked ? '\0' : '*';
            register_cpassword.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void register_password_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_username_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void register_cpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
