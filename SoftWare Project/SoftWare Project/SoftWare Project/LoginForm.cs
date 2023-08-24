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
    public partial class LoginForm : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "Ahmed Nasr" && EmailTextBox.Text == "ahmed.nasr@gmail.com" && PasswordTextBox.Text == "Ahmed123456") // Admin
            {
                AdminForm admin = new AdminForm();
                this.Hide();
                admin.Show();
            }
            else
            {
                int isExist = 0;
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand student = new OracleCommand();
                student.Connection = conn;
                student.CommandText = "select STUDENT_NAME, EMAIL, STUDENT_PASSWORD from STUDENTTABLE where STUDENT_NAME =:NameTextBox AND EMAIL =: EmailTextBox And STUDENT_PASSWORD =: PasswordTextBox";
                student.CommandType = CommandType.Text;
                student.Parameters.Add("NameTextBox", UsernameTextBox.Text);
                student.Parameters.Add("EmailTextBox", EmailTextBox.Text);
                student.Parameters.Add("PasswordTextBox", PasswordTextBox.Text);
                OracleDataReader drStudent = student.ExecuteReader();
                if (drStudent.Read())
                {
                    //MessageBox.Show("heelllo");
                    // student form
                    isExist = 1;
                    StudentForm studForm = new StudentForm();
                    this.Hide();
                    studForm.Show();
                }
                drStudent.Close();
                OracleCommand advisor = new OracleCommand();
                advisor.Connection = conn;
                advisor.CommandText = "select NAME1, EMAIL, PASSWORDD from ADVISORTABLE where NAME1 =:NameTextBox AND EMAIL =:EmailTextBox AND PASSWORDD =:PasswordTextBox";
                advisor.CommandType = CommandType.Text;
                advisor.Parameters.Add("NameTextBox", UsernameTextBox.Text);
                advisor.Parameters.Add("EmailTextBox", EmailTextBox.Text);
                advisor.Parameters.Add("PasswordTextBox", PasswordTextBox.Text);
                OracleDataReader drAdvisor = advisor.ExecuteReader();
                if (drAdvisor.Read())
                {
                    isExist = 1;
                    // student form
                    AdvisorForm advisorForm = new AdvisorForm();
                    this.Hide();
                    advisorForm.Show();
                }
                drAdvisor.Close();
                if (isExist == 0)
                {
                    MessageBox.Show("Invalid USER");
                }
                
            }
            //conn.Dispose();
            //MessageBox.Show("Invalid USER");
        }

    }
}
