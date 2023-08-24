
namespace SoftWare_Project
{
    partial class AdminForm
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
            this.AdvisorButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvisorButton
            // 
            this.AdvisorButton.BackColor = System.Drawing.Color.Gray;
            this.AdvisorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvisorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdvisorButton.Location = new System.Drawing.Point(846, 402);
            this.AdvisorButton.Name = "AdvisorButton";
            this.AdvisorButton.Size = new System.Drawing.Size(131, 70);
            this.AdvisorButton.TabIndex = 21;
            this.AdvisorButton.Text = "Advisor";
            this.AdvisorButton.UseVisualStyleBackColor = false;
            this.AdvisorButton.Click += new System.EventHandler(this.AdvisorButton_Click);
            // 
            // StudentButton
            // 
            this.StudentButton.BackColor = System.Drawing.Color.Gray;
            this.StudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentButton.Location = new System.Drawing.Point(846, 218);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(131, 70);
            this.StudentButton.TabIndex = 20;
            this.StudentButton.Text = "Student";
            this.StudentButton.UseVisualStyleBackColor = false;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(372, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(428, 69);
            this.label5.TabIndex = 18;
            this.label5.Text = "Create Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftWare_Project.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SoftWare_Project.Properties.Resources.Teacher_student_pana;
            this.pictureBox4.Location = new System.Drawing.Point(12, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(683, 546);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdvisorButton);
            this.Controls.Add(this.StudentButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Name = "AdminForm";
            this.Text = "Graduation Project Management System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AdvisorButton;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}