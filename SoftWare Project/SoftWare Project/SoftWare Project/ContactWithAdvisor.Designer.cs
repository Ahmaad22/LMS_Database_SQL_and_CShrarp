
namespace SoftWare_Project
{
    partial class ContactWithAdvisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.SSN = new System.Windows.Forms.Label();
            this.AdvisorEmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(343, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(487, 69);
            this.label5.TabIndex = 20;
            this.label5.Text = "Get Advisor Email";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(747, 233);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(403, 32);
            this.ProjectNameTextBox.TabIndex = 23;
            // 
            // SSN
            // 
            this.SSN.AutoSize = true;
            this.SSN.BackColor = System.Drawing.Color.Silver;
            this.SSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN.ForeColor = System.Drawing.Color.Black;
            this.SSN.Location = new System.Drawing.Point(743, 203);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(111, 20);
            this.SSN.TabIndex = 22;
            this.SSN.Text = "Project Name";
            // 
            // AdvisorEmailTextBox
            // 
            this.AdvisorEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvisorEmailTextBox.Location = new System.Drawing.Point(747, 436);
            this.AdvisorEmailTextBox.Name = "AdvisorEmailTextBox";
            this.AdvisorEmailTextBox.Size = new System.Drawing.Size(403, 32);
            this.AdvisorEmailTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(743, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Advisor Email";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Gray;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Location = new System.Drawing.Point(1034, 296);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(116, 59);
            this.SearchButton.TabIndex = 26;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftWare_Project.Properties.Resources.New_message_pana;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(699, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoftWare_Project.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ContactWithAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdvisorEmailTextBox);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ContactWithAdvisor";
            this.Text = "ContactWithAdvisor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label SSN;
        private System.Windows.Forms.TextBox AdvisorEmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}