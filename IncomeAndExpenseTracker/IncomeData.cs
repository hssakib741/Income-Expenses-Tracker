using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeAndExpenseTracker
{
    internal class IncomeData
    {
        string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        
        public int ID {  get; set; }
        public string Category { get; set; }
        public string Item {  get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string DateIncome {  get; set; }

        public List<IncomeData> incomeListData()
        {
            List<IncomeData> listData=new List<IncomeData>();

            SqlConnection conn=new SqlConnection(stringConn);
            conn.Open();

            string selectDate = "SELECT * FROM income";

            SqlCommand cmd=new SqlCommand(selectDate, conn);

            SqlDataReader reader=cmd.ExecuteReader();

            while (reader.Read())
            {

                IncomeData iData=new IncomeData();

                iData.ID=(int)reader["id"];
                iData.Category=reader["category"].ToString();
                iData.Item=reader["item"].ToString();
                iData.Cost = reader["income"].ToString();
                iData.Description= reader["description"].ToString();
                iData.DateIncome=((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");

                listData.Add(iData);

                
            }
            return listData;
        }
    }
}
