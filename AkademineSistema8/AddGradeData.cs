using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema8
{  
    internal class AddGradeData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public int ID { get; set; }
        public string GradeID { get; set; }
        public string GradeStudent { get; set; }
        public string GradeSubject { get; set; }
        public string Grade { get; set; }
        public string DateInsert { get; set; }

        public List<AddGradeData> gradeData()
        {
            List<AddGradeData> listData = new List<AddGradeData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM grade WHERE date_delete is NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddGradeData addTD = new AddGradeData();
                            addTD.ID = (int)reader["id"];
                            addTD.GradeID = reader["grade_id"].ToString();
                            addTD.GradeStudent = reader["grade_student"].ToString();
                            addTD.GradeSubject = reader["grade_subject"].ToString();
                            addTD.Grade = reader["grade"].ToString();
                            addTD.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addTD);
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
