using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema8
{
    public partial class AddSubjectForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public AddSubjectForm()
        {
            InitializeComponent();

            displaySubjectData();
        }

        public void displaySubjectData()
        {
            AddSubjectData adData = new AddSubjectData();
            List<AddSubjectData> subjectList = adData.SubjectData();

            if (subjectList.Count > 0)
            {
                Console.WriteLine($"Loaded {subjectList.Count} rows into DataGridView.");
            }
            else
            {
                Console.WriteLine("No data to display.");
            }

            subject_gridData.DataSource = null; 
            subject_gridData.DataSource = subjectList;
        }

        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = subject_gridData.Rows[e.RowIndex];
                subject_name.Text = row.Cells[1].Value.ToString();
            }
        }

        private void subject_addBtn_Click(object sender, EventArgs e)
        {
            if (subject_name.Text == "")

            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string checkStudentID = "SELECT COUNT(*) FROM subject WHERE subject_name = @subjectName";

                        using (SqlCommand checkSID = new SqlCommand(checkStudentID, connect))
                        {
                            checkSID.Parameters.AddWithValue("@subjectName", subject_name.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Subject Name: " + subject_name.Text.Trim() + "already  exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO subject " +
                             "(subject_name, date_insert) " +
                             "VALUES(@subjectName, @dateInsert)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@subjectName", subject_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    displaySubjectData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void clearFields()
        {
            subject_name.Text = "";
        }

        private void subject_updateBtn_Click(object sender, EventArgs e)
        {
            if (subject_name.Text == "")

            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Subject Name: "
                            + subject_name.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE subject SET subject_name = @subjectName, " +
                                "date_update = @dateUpdate " +
                                "WHERE subject_name = @subjectName";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@subjectName", subject_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();

                                displaySubjectData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void subject_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void subject_deleteBtn_Click(object sender, EventArgs e)
        {
            if (subject_name.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Subject Name: "
                        + subject_name.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE subject SET date_delete = @dateDelete " +
                                "WHERE subject_name = @subjectName";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@subjectName", subject_name.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displaySubjectData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting Database: " + ex, "Error Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
