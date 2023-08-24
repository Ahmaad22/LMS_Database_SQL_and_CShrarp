﻿using System;
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
    public partial class ContactWithAdvisor : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public ContactWithAdvisor()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.Show();
        }
        private void ContactWithAdvisor_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetAdvisorEmail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("projectname", ProjectNameTextBox.Text.ToString());
            cmd.Parameters.Add("AdvisorPhone", OracleDbType.Int64, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            AdvisorEmailTextBox.Text = cmd.Parameters[1].Value.ToString();

        }
    }
}
