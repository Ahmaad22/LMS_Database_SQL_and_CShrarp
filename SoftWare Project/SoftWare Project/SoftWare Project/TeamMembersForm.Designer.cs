
namespace SoftWare_Project
{
    partial class TeamMembersForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.TeamNumberTextBox = new System.Windows.Forms.TextBox();
            this.SSN = new System.Windows.Forms.Label();
            this.TeamMembersEmailsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label5.Location = new System.Drawing.Point(319, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(547, 69);
            this.label5.TabIndex = 22;
            this.label5.Text = "Get Team Members ";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Gray;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Location = new System.Drawing.Point(973, 273);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(124, 59);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // TeamNumberTextBox
            // 
            this.TeamNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNumberTextBox.Location = new System.Drawing.Point(694, 210);
            this.TeamNumberTextBox.Name = "TeamNumberTextBox";
            this.TeamNumberTextBox.Size = new System.Drawing.Size(403, 32);
            this.TeamNumberTextBox.TabIndex = 31;
            // 
            // SSN
            // 
            this.SSN.AutoSize = true;
            this.SSN.BackColor = System.Drawing.Color.Silver;
            this.SSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN.ForeColor = System.Drawing.Color.Black;
            this.SSN.Location = new System.Drawing.Point(690, 180);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(115, 20);
            this.SSN.TabIndex = 30;
            this.SSN.Text = "Team Number";
            // 
            // TeamMembersEmailsComboBox
            // 
            this.TeamMembersEmailsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMembersEmailsComboBox.FormattingEnabled = true;
            this.TeamMembersEmailsComboBox.Location = new System.Drawing.Point(694, 440);
            this.TeamMembersEmailsComboBox.Name = "TeamMembersEmailsComboBox";
            this.TeamMembersEmailsComboBox.Size = new System.Drawing.Size(403, 34);
            this.TeamMembersEmailsComboBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(690, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Team Members Emails";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftWare_Project.Properties.Resources.Collab_pana;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoftWare_Project.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TeamMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamMembersEmailsComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TeamNumberTextBox);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TeamMembersForm";
            this.Text = "TeamMembersForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox TeamNumberTextBox;
        private System.Windows.Forms.Label SSN;
        private System.Windows.Forms.ComboBox TeamMembersEmailsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}