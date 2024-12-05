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
    internal class AddGroupData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public int ID { get; set; }
        public string GroupName { get; set; }
        public string DateInsert { get; set; }

        public List<AddGroupData> GroupData()
        {
            List<AddGroupData> listData = new List<AddGroupData>();

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                string sql = "SELECT group_id, group_name, date_insert FROM [group] WHERE date_delete IS NULL";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No data found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return listData; // Return an empty list if no data
                        }

                        while (reader.Read())
                        {
                            AddGroupData addSD = new AddGroupData
                            {
                                ID = (int)reader["group_id"],
                                GroupName = reader["group_name"].ToString(),
                                DateInsert = reader["date_insert"].ToString()
                            };

                            listData.Add(addSD);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}
