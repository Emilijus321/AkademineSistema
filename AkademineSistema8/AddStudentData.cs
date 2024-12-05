using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AkademineSistema8
{
    internal class AddStudentData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentUsertype { get; set; }
        public string StudentGroup { get; set; }
        public string StudentStatus { get; set; }
        public string DateInsert { get; set; }

        public List<AddStudentData> studentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM students WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addSD = new AddStudentData();
                            addSD.ID = (int)reader["id"];
                            addSD.StudentID = reader["student_id"].ToString();
                            addSD.StudentName = reader["student_name"].ToString();
                            addSD.StudentSurname = reader["student_surname"].ToString();
                            addSD.StudentUsertype = reader["student_usertype"].ToString();
                            addSD.StudentGroup = reader["student_group"].ToString();
                            addSD.StudentStatus = reader["student_status"].ToString();
                            addSD.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addSD);
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

        public List<AddStudentData> dashboardStudentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;
                    string sql = "SELECT * FROM students WHERE date_insert = @dateInsert " +
                        "AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@dateInsert", today.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addSD = new AddStudentData();
                            addSD.ID = (int)reader["id"];
                            addSD.StudentID = reader["student_id"].ToString();
                            addSD.StudentName = reader["student_name"].ToString();
                            addSD.StudentSurname = reader["student_surname"].ToString();
                            addSD.StudentUsertype = reader["student_usertype"].ToString();
                            addSD.StudentGroup = reader["student_group"].ToString();
                            addSD.StudentStatus = reader["student_status"].ToString();
                            addSD.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
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
