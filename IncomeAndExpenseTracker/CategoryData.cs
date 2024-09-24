using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace IncomeAndExpenseTracker
{
    internal class CategoryData
    {
        string stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        
        public int ID { set; get; }
        public string Category {  set; get; }
        public string Type { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<CategoryData> categoryListData()
        {

        List<CategoryData> listData= new List<CategoryData>();
            SqlConnection conn=new SqlConnection(stringConn);

            conn.Open();
            string selectData = "SELECT * FROM categories";

            SqlCommand cmd= new SqlCommand(selectData, conn);
            
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CategoryData data = new CategoryData();
                data.ID=(int)reader["id"];
                data.Category = reader["category"].ToString();
                data.Type = reader["type"].ToString();
                data.Status = reader["status"].ToString();
                data.Date = reader["date_insert"].ToString();

                listData.Add(data);
            }
            return listData;
        }
        
    }
}
