using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace SoftWare_Project
{
    public partial class TeamMembersForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public TeamMembersForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdvisorForm advisorForm = new AdvisorForm();
            this.Hide();
            advisorForm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            TeamMembersIDsComboBox.Items.Clear();
            if (TeamNumberTextBox.Text == "")
            {
                MessageBox.Show("Complete your data");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select STUDENT_ID from STUDENTTABLE where TEAM_NUMBER =:teamNumber";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("teamNumber", TeamNumberTextBox.Text);
                OracleDataReader read_team_number = cmd.ExecuteReader();
                while (read_team_number.Read())
                {
                    TeamMembersIDsComboBox.Items.Add(read_team_number["STUDENT_ID"]);
                }
                read_team_number.Close();
            }

        }

    }
}
