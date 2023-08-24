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
    public partial class CreateStudentAccount : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public CreateStudentAccount()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.Show();
        }

        private void CreateAdvisorAccountButton_Click(object sender, EventArgs e)
        {
            if (SSNTextBox.Text == "" || UsernameTextBox.Text == "" || EmailTextBox.Text == "" || PassowrdTextBox.Text == "" || TeamNumberTextBox.Text == "" || ProjectIDTextBox.Text == "")
            {
                MessageBox.Show("Complete your data");
            }
            else
            {

                // Get Max student ID
                conn = new OracleConnection(ordb);
                conn.Open();
                int maxId, newId;
                OracleCommand getMaxId = new OracleCommand();
                getMaxId.Connection = conn;
                getMaxId.CommandText = "GETMAXSTUDENTID";
                getMaxId.CommandType = CommandType.StoredProcedure;
                getMaxId.Parameters.Add("STUDENT_ID", OracleDbType.Int32, ParameterDirection.Output);
                getMaxId.ExecuteNonQuery();
                try
                {
                    maxId = Convert.ToInt32(getMaxId.Parameters["STUDENT_ID"].Value.ToString());
                    newId = maxId + 1;
                }
                catch
                {
                    newId = 1;
                }



                // Get Advisor ID from Project ID
                OracleCommand GetAdvisorId = new OracleCommand();
                GetAdvisorId.Connection = conn;
                GetAdvisorId.CommandText = "select PROJECT_ADVISORID from PROJECTTABLE where PROJECTID =:projectID";
                GetAdvisorId.CommandType = CommandType.Text;
                GetAdvisorId.Parameters.Add("projectID", ProjectIDTextBox.Text);
                int advisorID = 0;
                OracleDataReader drGetAdvisorId = GetAdvisorId.ExecuteReader();
                if (drGetAdvisorId.Read())
                {
                    advisorID = Convert.ToInt32(drGetAdvisorId["PROJECT_ADVISORID"].ToString());  // error
                }
                drGetAdvisorId.Close();

                // insert new student
                OracleCommand insertAdvisor = new OracleCommand();
                insertAdvisor.Connection = conn;
                insertAdvisor.CommandText = "insert into STUDENTTABLE (STUDENT_ID, SSN, STUDENT_NAME, EMAIL, STUDENT_PASSWORD,TEAM_NUMBER,ADVISORID,STUDENT_PROJECTID)  Values (:ID,:Ssn,:Student_Name,:Email,:Student_password,:Team_Number,:Project_ID,:advisorID)";
                insertAdvisor.CommandType = CommandType.Text;
                insertAdvisor.Parameters.Add("ID", newId);
                insertAdvisor.Parameters.Add("Ssn", SSNTextBox.Text);
                insertAdvisor.Parameters.Add("Student_Name", UsernameTextBox.Text);
                insertAdvisor.Parameters.Add("Email", EmailTextBox.Text);
                insertAdvisor.Parameters.Add("Student_password", PassowrdTextBox.Text);
                insertAdvisor.Parameters.Add("Team_Number", TeamNumberTextBox.Text);
                insertAdvisor.Parameters.Add("advisorID", advisorID);
                insertAdvisor.Parameters.Add("Project_ID", ProjectIDTextBox.Text);
                int read_new_rows = insertAdvisor.ExecuteNonQuery();

                if (read_new_rows != -1)
                {
                    MessageBox.Show("New data for Advisor is added");
                }
                else
                {
                    MessageBox.Show("Insertion failed");
                }

            }
        }

    }
}