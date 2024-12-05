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

namespace AkademineSistema8
{
    public partial class AddGradeForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public AddGradeForm()
        {
            InitializeComponent();

            gradeDisplayData();
        }

        public void gradeDisplayData()
        {
            AddGradeData addTD = new AddGradeData();

            grade_gridData.DataSource = addTD.gradeData();

        }

        private void grade_addBtn_Click(object sender, EventArgs e)
        {
            if (grade_id.Text == ""
                || grade_student.Text == ""
                || grade_subject.Text == ""
                || grade.Text == "")
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

                        string checkGradeID = "SELECT COUNT(*) FROM grade WHERE grade_id = @gradeID";

                        using (SqlCommand checkGID = new SqlCommand(checkGradeID, connect))
                        {
                            checkGID.Parameters.AddWithValue("@gradeID", grade_id.Text.Trim());
                            int count = (int)checkGID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Grade ID: " + grade_id.Text.Trim() + "already  exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO grade " +
                            "(grade_id, grade_student, grade_subject, grade, date_insert) " +
                            "VALUES(@gradeID, @gradeStudent, @gradeSubject, @Grade, @dateInsert)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@gradeID", grade_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gradeStudent", grade_student.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gradeSubject", grade_subject.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Grade", grade.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();

                                    gradeDisplayData();

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
            grade_id.Text = "";
            grade_student.SelectedIndex = -1;
            grade_subject.SelectedIndex = -1;
            grade.SelectedIndex = -1;
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            FillComboStudentCode();
            FillComboSubjectCode();
        }
        private void FillComboStudentCode()
        {
            grade_student.Items.Clear();
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT student_name FROM students";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                grade_student.Items.Add(dr["student_name"].ToString());
            }
            connect.Close();
        }
        private void FillComboSubjectCode()
        {
            grade_subject.Items.Clear();
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
                grade_subject.Items.Add(dr["subject_name"].ToString());
            }
            connect.Close();
        }

        private void grade_updateBtn_Click(object sender, EventArgs e)
        {
            if (grade_id.Text == ""
                || grade_student.Text == ""
                || grade_subject.Text == ""
                || grade.Text == "")
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

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Grade ID: "
                            + grade_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE grade SET " +
                                "grade_student = @gradeStudent, grade_subject = @gradeSubject" +
                                ", grade = @Grade" +
                                ", date_update = @dateUpdate WHERE grade_id = @gradeID";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@gradeID", grade_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@gradeStudent", grade_student.Text.Trim());
                                cmd.Parameters.AddWithValue("@gradeSubject", grade_subject.Text.Trim());
                                cmd.Parameters.AddWithValue("@Grade", grade.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();

                                gradeDisplayData();

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

        private void grade_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void grade_deleteBtn_Click(object sender, EventArgs e)
        {
            if (grade_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Grade ID: "
                        + grade_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE grade SET date_delete = @dateDelete " +
                                "WHERE grade_id = @gradeID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@gradeID", grade_id.Text.Trim());

                                cmd.ExecuteNonQuery();

                                gradeDisplayData();

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

        private void grade_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = grade_gridData.Rows[e.RowIndex];
                grade_id.Text = row.Cells[1].Value.ToString();
                grade_student.Text = row.Cells[2].Value.ToString();
                grade_subject.Text = row.Cells[3].Value.ToString();
                grade.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
