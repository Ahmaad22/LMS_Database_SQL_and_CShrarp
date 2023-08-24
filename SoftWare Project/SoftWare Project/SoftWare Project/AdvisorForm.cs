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
    public partial class AdvisorForm : Form
    {
        public AdvisorForm()
        {
            InitializeComponent();
        }

        private void UpdateEvaluationButton_Click(object sender, EventArgs e)
        {
            UpdateEvaluationForm updateEvaluationForm = new UpdateEvaluationForm();
            this.Hide();
            updateEvaluationForm.Show();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            TeamMembersForm teamMembersForm = new TeamMembersForm();
            this.Hide();
            teamMembersForm.Show();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            StudentsInSpacificProjectForm studentsInSpacificProjectForm = new StudentsInSpacificProjectForm();
            this.Hide();
            studentsInSpacificProjectForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
