using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm dForm = new DashboardForm();
            dForm.displayEnrolledStudentToday();
            dForm.displayTotalGS();
            dForm.displayTotalTT();
            dForm.displayTotalES();

            dashboardForm1.Visible = true;
            dashboardForm1.Update();
            addStudentForm1.Visible = false;
            addTeacherForm1.Visible = false;
            addGroupForm1.Visible = false;
            addSubjectForm1.Visible = false;
        }

        private void AddStudents_Btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentForm1.Visible = true;
            addStudentForm1.Update();
            addTeacherForm1.Visible = false;
            addGroupForm1.Visible = false;
            addSubjectForm1.Visible = false;
        }

        private void AddTeachers_Btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentForm1.Visible = false;
            addTeacherForm1.Visible = true;
            addTeacherForm1.Update();
            addGroupForm1.Visible = false;
            addSubjectForm1.Visible = false;
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentForm1.Visible = false;
            addTeacherForm1.Visible = false;
            addGroupForm1.Visible = true;
            addGroupForm1.Update();
            addSubjectForm1.Visible = false;
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentForm1.Visible = false;
            addTeacherForm1.Visible = false;
            addGroupForm1.Visible = false;
            addSubjectForm1.Visible = true;
            addSubjectForm1.Update();
        }
    }
}
