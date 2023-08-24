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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            ContactWithAdvisor contactWithAdvisor = new ContactWithAdvisor();
            this.Hide();
            contactWithAdvisor.Show();
        }

        private void GetNowButton_Click(object sender, EventArgs e)
        {
            StudentEvaluationForm studentEvaluationForm = new StudentEvaluationForm();
            this.Hide();
            studentEvaluationForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

      
    }
}
