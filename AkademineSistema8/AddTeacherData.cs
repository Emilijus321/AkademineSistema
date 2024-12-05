using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AkademineSistema8
{
    internal class AddTeacherData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public int ID { get; set; }
        public string teacherID { get; set; }
        public string teacherName { get; set; }
        public string teacherSurname { get; set; }
        public string teacherUsertype { get; set; }
        public string teacherSubject { get; set; }
        public string Status { get; set; }
        public string DateInsert { get; set; }

        public List<AddTeacherData> teacherData ()
        {
            List<AddTeacherData> listData = new List<AddTeacherData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM teachers WHERE date_delete is NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddTeacherData addTD = new AddTeacherData();
                            addTD.ID = (int)reader["id"];
                            addTD.teacherID = reader["teacher_id"].ToString();
                            addTD.teacherName = reader["teacher_name"].ToString();
                            addTD.teacherSurname = reader["teacher_surname"].ToString();
                            addTD.teacherUsertype = reader["teacher_usertype"].ToString();
                            addTD.teacherSubject = reader["teacher_subject"].ToString();
                            addTD.Status = reader["teacher_status"].ToString();
                            addTD.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addTD);
                        }
                        reader.Close();
                    }
                    
                }
                catch(Exception ex)
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
