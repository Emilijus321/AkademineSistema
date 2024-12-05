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
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    string adminQuery = "SELECT 'Admin' AS role FROM admin WHERE username = @username AND password = @password";
                    string teacherQuery = "SELECT 'Teacher' AS role FROM teachers WHERE teacher_name = @username AND teacher_surname = @password";
                    string studentQuery = "SELECT 'Student' AS role FROM students WHERE student_name = @username AND student_surname = @password";

                    string combinedQuery = $"{adminQuery} UNION {teacherQuery} UNION {studentQuery}";


                    using (SqlCommand cmd = new SqlCommand(combinedQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string role = table.Rows[0]["role"].ToString();
                            MessageBox.Show($"Login Successful as {role}!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (role == "Admin")
                            {
                                MainForm lForm = new MainForm();
                                lForm.Show();
                            }
                            else if (role == "Teacher")
                            {
                                TeacherMainForm teacherForm = new TeacherMainForm();
                                teacherForm.Show();
                            }
                            else if (role == "Student")
                            {
                                StudentMainForm studentForm = new StudentMainForm();
                                studentForm.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}
