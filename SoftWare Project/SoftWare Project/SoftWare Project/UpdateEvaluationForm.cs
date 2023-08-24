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
    public partial class UpdateEvaluationForm : Form
    {
        public UpdateEvaluationForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdvisorForm advisorForm = new AdvisorForm();
            this.Hide();
            advisorForm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
