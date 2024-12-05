using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace AkademineSistema8
{
    public partial class AddStudentForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public AddStudentForm()
        {
            InitializeComponent();

            displayStudentData();
        }

        public void displayStudentData()
        {
            AddStudentData adData = new AddStudentData();

            student_studentData.DataSource = adData.studentData();
        }

        private void student_addBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_surname.Text == ""
                || student_usertype.Text == ""
                || student_group.Text == ""
                || student_status.Text == "")
               
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

                        
                        string checkStudentID = "SELECT COUNT(*) FROM students WHERE student_id = @studentID";

                        using (SqlCommand checkSID = new SqlCommand(checkStudentID, connect))
                        {
                            checkSID.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Student ID: " + student_id.Text.Trim() + " is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO students (student_id, student_name" +
                                    ", student_surname, student_usertype, student_group, student_status, date_insert) " +
                                    "VALUES(@studentID, @studentName, @studentSurname, @studentUsertype" +
                                    ", @studentGroup, @studentStatus, @dateInsert)";
                                 
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentSurname", student_surname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentUsertype", student_usertype.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentGroup", student_group.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    displayStudentData();

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
            student_id.Text = "";
            student_name.Text = "";
            student_surname.Text = "";
            student_usertype.SelectedIndex = -1;
            student_group.SelectedIndex = -1;
            student_status.SelectedIndex = -1;
        }

        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_surname.Text == ""
                || student_usertype.Text == ""
                || student_group.Text == ""
                || student_status.Text == "")
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

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Student ID: "
                            + student_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE students SET student_name = @studentName, " +
                                "student_surname = @studentSurname, student_usertype = @studentUsertype, " + // Use correct column name here
                                "student_group = @studentGroup, student_status = @studentStatus, date_update = @dateUpdate " + // No comma here
                                "WHERE student_id = @studentID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentSurname", student_surname.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentUsertype", student_usertype.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentGroup", student_group.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString("yyyy-MM-dd")); // Correctly adding @dateUpdate
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim()); // Ensure @studentID is included

                                cmd.ExecuteNonQuery();

                                displayStudentData();

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

        private void student_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Student ID: "
                        + student_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE students SET date_delete = @dateDelete " +
                                "WHERE student_id = @studentID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayStudentData();

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


        private void student_studentData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_studentData.Rows[e.RowIndex];
                student_id.Text = row.Cells[1].Value.ToString();
                student_name.Text = row.Cells[2].Value.ToString();
                student_surname.Text = row.Cells[3].Value.ToString();
                student_usertype.Text = row.Cells[4].Value.ToString();
                student_group.Text = row.Cells[5].Value.ToString();
                student_status.Text = row.Cells[6].Value.ToString();
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            FillComboGroupCode();
        }

        private void FillComboGroupCode()
        {
            student_group.Items.Clear();
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT group_name FROM [group]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                student_group.Items.Add(dr["group_name"].ToString());
            }
            connect.Close();
        }
        
    }
}
