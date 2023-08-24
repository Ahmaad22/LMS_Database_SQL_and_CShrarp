using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace SoftWare_Project
{
    public partial class StudentEvaluationForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public StudentEvaluationForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetStudentEvaluation";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", Convert.ToInt32(StudentIDTextBox.Text));
            cmd.Parameters.Add("Evaluation", OracleDbType.Int64, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            StudentEvaluationTextBox.Text = cmd.Parameters["Evaluation"].Value.ToString();
        }
        private void StudentEvaluationForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
