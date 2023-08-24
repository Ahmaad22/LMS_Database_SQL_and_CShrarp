
namespace SoftWare_Project
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetNowButton = new System.Windows.Forms.Button();
            this.ContactButton = new System.Windows.Forms.Button();
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
            this.label5.Location = new System.Drawing.Point(668, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 69);
            this.label5.TabIndex = 19;
            this.label5.Text = "Welcome Back !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(622, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Contact with Advisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(622, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Check Evaluation Now ";
            // 
            // GetNowButton
            // 
            this.GetNowButton.BackColor = System.Drawing.Color.Gray;
            this.GetNowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetNowButton.Location = new System.Drawing.Point(993, 512);
            this.GetNowButton.Name = "GetNowButton";
            this.GetNowButton.Size = new System.Drawing.Size(120, 55);
            this.GetNowButton.TabIndex = 23;
            this.GetNowButton.Text = "Get Now";
            this.GetNowButton.UseVisualStyleBackColor = false;
            this.GetNowButton.Click += new System.EventHandler(this.GetNowButton_Click);
            // 
            // ContactButton
            // 
            this.ContactButton.BackColor = System.Drawing.Color.Gray;
            this.ContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContactButton.Location = new System.Drawing.Point(993, 281);
            this.ContactButton.Name = "ContactButton";
            this.ContactButton.Size = new System.Drawing.Size(120, 57);
            this.ContactButton.TabIndex = 24;
            this.ContactButton.Text = "Contact";
            this.ContactButton.UseVisualStyleBackColor = false;
            this.ContactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftWare_Project.Properties.Resources.Thesis_pana;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 593);
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
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1182, 651);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ContactButton);
            this.Controls.Add(this.GetNowButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetNowButton;
        private System.Windows.Forms.Button ContactButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}