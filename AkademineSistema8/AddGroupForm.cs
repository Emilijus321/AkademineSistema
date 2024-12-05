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
    public partial class AddGroupForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public AddGroupForm()
        {
            InitializeComponent();

            displayGroupData();
        }

        public void displayGroupData()
        {
            AddGroupData adData = new AddGroupData();

            group_gridData.DataSource = adData.GroupData();
        }

        private void student_addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(group_name.Text))
            {
                MessageBox.Show("Please enter a group name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                string checkQuery = "SELECT COUNT(*) FROM [group] WHERE group_name = @groupName AND date_delete IS NULL";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                {
                    checkCmd.Parameters.AddWithValue("@groupName", group_name.Text.Trim());
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show($"Group name '{group_name.Text.Trim()}' already exists!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO [group] (group_name, date_insert) VALUES (@groupName, @dateInsert)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connect))
                {
                    insertCmd.Parameters.AddWithValue("@groupName", group_name.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@dateInsert", DateTime.Today.ToString("yyyy-MM-dd"));
                    insertCmd.ExecuteNonQuery();
                }

                displayGroupData();

                MessageBox.Show("Group added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                group_name.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        public void clearFields()
        {
            group_name.Text = "";
        }

        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            if (group_name.Text == "")

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

                        DialogResult check = MessageBox.Show("Are you sure you want to Update Group Name: "
                            + group_name.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            String updateData = "UPDATE [group] SET group_name = @groupName, " +
                                " date_update = @dateUpdate " +
                                "WHERE group_name = @groupName";


                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@groupName", group_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();

                                displayGroupData();

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

            if (group_name.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to Delete Student ID: "
                        + group_name.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {

                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string deleteData = "UPDATE [group] SET date_delete = @dateDelete " +
                                "WHERE group_name = @groupName";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@groupName", group_name.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayGroupData();

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

        private void group_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = group_gridData.Rows[e.RowIndex];
                group_name.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
