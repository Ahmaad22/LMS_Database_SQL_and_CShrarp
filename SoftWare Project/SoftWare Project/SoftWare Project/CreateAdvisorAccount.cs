
////////////   CreateAdvisorAccount   ///////////




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
    public partial class CreateAdvisorAccount : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public CreateAdvisorAccount()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.Show();
        }

        private void CreateAdvisorAccountButton_Click_1(object sender, EventArgs e)
        {

            if (SSNTextBox.Text == "" || UsernameTextBox.Text == "" || EmailTextBox.Text == "" || PassowrdTextBox.Text == "" || ProjectNameTextBox.Text == "")
            {
                MessageBox.Show("Complete your data");
            }
            else
            {
                // Get Max Advisor ID
                conn = new OracleConnection(ordb);
                conn.Open();
                int maxId, newId;
                OracleCommand getMaxId = new OracleCommand();
                getMaxId.Connection = conn;
                getMaxId.CommandText = "GETMAXADVISORID";
                getMaxId.CommandType = CommandType.StoredProcedure;
                getMaxId.Parameters.Add("Advisor_Id", OracleDbType.Int32, ParameterDirection.Output);
                getMaxId.ExecuteNonQuery();
                try
                {
                    maxId = Convert.ToInt32(getMaxId.Parameters["Advisor_Id"].Value.ToString());
                    newId = maxId + 1;
                }
                catch
                {
                    newId = 1;
                }

                // insert new Advisor
                OracleCommand insertAdvisor = new OracleCommand();
                insertAdvisor.Connection = conn;
                insertAdvisor.CommandText = "insert into ADVISORTABLE Values (:ID,:Ssn,:Name1,:Email,:passwordd,:projectName)";
                insertAdvisor.CommandType = CommandType.Text;
                insertAdvisor.Parameters.Add("ID", newId);
                insertAdvisor.Parameters.Add("Ssn", SSNTextBox.Text);
                insertAdvisor.Parameters.Add("Name1", UsernameTextBox.Text);
                insertAdvisor.Parameters.Add("Email", EmailTextBox.Text);
                insertAdvisor.Parameters.Add("passwordd", PassowrdTextBox.Text);
                insertAdvisor.Parameters.Add("projectName", ProjectNameTextBox.Text);
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