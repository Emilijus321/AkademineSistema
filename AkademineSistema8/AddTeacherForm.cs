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
using System.IO;

namespace AkademineSistema8
{
    public partial class AddTeacherForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public AddTeacherForm()
        {
            InitializeComponent();

            teacherDisplayData();
        }
        public void teacherDisplayData()
        {
            AddTeacherData addTD = new AddTeacherData();

            teacher_gridData.DataSource = addTD.teacherData();

        }

        private void teacher_addBtn_Click(object sender, EventArgs e)
        {
            if(teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_surname.Text == ""
                || teacher_usertype.Text == ""
                || teacher_subject.Text == ""
                || teacher_status.Text == "")
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

                        string checkTeacherID = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @teacherID";

                        using(SqlCommand checkTID = new SqlCommand(checkTeacherID, connect))
                        {
                            checkTID.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                            int count = (int)checkTID.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show("Teacher ID: " + teacher_id.Text.Trim() + "already  exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO teachers " +
                            "(teacher_id, teacher_name, teacher_surname, teacher_usertype, " +
                            "teacher_subject, teacher_status, date_insert) " +
                            "VALUES(@teacherID, @teacherName, @teacherSurname, @teacherUsertype, " +
                            "@teacherSubject, @teacherStatus, @dateInsert)";

                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherSurname", teacher_surname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherUsertype", teacher_usertype.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherSubject", teacher_subject.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherStatus", teacher_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    teacherDisplayData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
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
            teacher_id.Text = "";
            teacher_name.Text = "";
            teacher_surname.Text = "";
            teacher_usertype.SelectedIndex = -1;
            teacher_subject.Text = "";
            teacher_status.SelectedIndex = -1;
        }

        private void teacher_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void teacher_updateBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_surname.Text == ""
                || teacher_usertype.Text == ""
                || teacher_subject.Text == ""
                || teacher_status.Text == "")
            {
                MessageBox.Show("Please select item firt", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Teacher ID: "
                            + teacher_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE teachers SET " +
                                "teacher_name = @teacherName, teacher_surname = @teacherSurname" +
                                ", teacher_usertype = @teacherUsertype" +
                                ", teacher_subject = @teacherSubject" +
                                ", teacher_group = @teacherGroup" +
                                ", date_update = @dateUpdate WHERE teacher_id = @teacherID";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherSurname", teacher_surname.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherUsertype", teacher_usertype.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherSubject", teacher_subject.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherStatus", teacher_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                cmd.ExecuteNonQuery();

                                teacherDisplayData();

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

        private void teacher_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_gridData.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_surname.Text = row.Cells[3].Value.ToString();
                teacher_usertype.Text = row.Cells[4].Value.ToString();
                teacher_subject.Text = row.Cells[5].Value.ToString();
                teacher_status.Text = row.Cells[7].Value.ToString();
            }
        }

        private void teacher_deleteBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Teacher ID: "
                        + teacher_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE teachers SET date_delete = @dateDelete " +
                                "WHERE teacher_id = @teacherID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                teacherDisplayData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error  connecting Database: " + ex, "Error Message"
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

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            FillComboSubjectCode();
        }

        private void FillComboSubjectCode()
        {
            teacher_subject.Items.Clear();
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT subject_name FROM subject";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                teacher_subject.Items.Add(dr["subject_name"].ToString());
            }
            connect.Close();
        }

    }
}
