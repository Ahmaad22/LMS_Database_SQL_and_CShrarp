using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftWare_Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentAccount studentAccount = new CreateStudentAccount();
            this.Hide();
            studentAccount.Show();
        }

        private void AdvisorButton_Click(object sender, EventArgs e)
        {
            CreateAdvisorAccount advisorAccount = new CreateAdvisorAccount();
            this.Hide();
            advisorAccount.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
