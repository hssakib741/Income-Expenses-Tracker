using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeAndExpenseTracker
{
    internal class ExpensesData
    {
        string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string DateIncome { get; set; }

        public List<ExpensesData> expenseListData()
        {
            List<ExpensesData> listData = new List<ExpensesData>();

            SqlConnection conn = new SqlConnection(stringConn);
            conn.Open();

            string selectDate = "SELECT * FROM expenses";

            SqlCommand cmd = new SqlCommand(selectDate, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                ExpensesData eData = new ExpensesData();

                eData.ID = (int)reader["id"];
                eData.Category = reader["category"].ToString();
                eData.Item = reader["item"].ToString();
                eData.Cost = reader["cost"].ToString();
                eData.Description = reader["description"].ToString();
                eData.DateIncome = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");

                listData.Add(eData);


            }
            return listData;
        }
    }
}
