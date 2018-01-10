using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCOFFEE.DAO
{
    public class DataProvider
    {
        private String connectionStr = @"Data Source=DESKTOP-QQS2LUE\SQLEXPRESS;Initial Catalog=QLCOFFEE;Integrated Security=True";

        public DataTable ExcuteQuery (String query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using( SqlConnection connection = new SqlConnection(connectionStr)) // giai phong bo nho cua lenh trong using sau khi thuc thi
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
           
            return data;

        }

        public int ExcuteNonQuery(String query, object[] parameter = null) //So dong thuc thi thanh cong
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr)) // giai phong bo nho cua lenh trong using sau khi thuc thi
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExcuteScalar(String query, object[] parameter = null) // cau lenh select * thuc thi co thanh cong hay k
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr)) // giai phong bo nho cua lenh trong using sau khi thuc thi
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}
