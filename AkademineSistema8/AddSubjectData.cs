using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema8
{
    internal class AddSubjectData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public string DateInsert { get; set; }

        public List<AddSubjectData> SubjectData()
        {
            List<AddSubjectData> listData = new List<AddSubjectData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT subject_id, subject_name, date_insert FROM subject WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddSubjectData subject = new AddSubjectData
                            {
                                ID = (int)reader["subject_id"],
                                SubjectName = reader["subject_name"].ToString(),
                                DateInsert = reader["date_insert"].ToString()
                            };
                            listData.Add(subject);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching data: " + ex.Message);
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


