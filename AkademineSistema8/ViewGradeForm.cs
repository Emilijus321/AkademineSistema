using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema8
{
    public partial class ViewGradeForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Juratei\Documents\school1.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public ViewGradeForm()
        {
            InitializeComponent();

            gradeDisplayData();
        }

        public void gradeDisplayData()
        {
            AddGradeData addGD = new AddGradeData();

            grade_gridData.DataSource = addGD.gradeData();

        }



        private void grade_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
