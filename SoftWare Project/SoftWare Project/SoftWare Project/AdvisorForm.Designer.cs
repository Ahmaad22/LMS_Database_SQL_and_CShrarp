
namespace SoftWare_Project
{
    partial class AdvisorForm
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
            this.UpdateEvaluationButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateEvaluationButton
            // 
            this.UpdateEvaluationButton.BackColor = System.Drawing.Color.Gray;
            this.UpdateEvaluationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateEvaluationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateEvaluationButton.Location = new System.Drawing.Point(1009, 217);
            this.UpdateEvaluationButton.Name = "UpdateEvaluationButton";
            this.UpdateEvaluationButton.Size = new System.Drawing.Size(130, 55);
            this.UpdateEvaluationButton.TabIndex = 29;
            this.UpdateEvaluationButton.Text = "Update";
            this.UpdateEvaluationButton.UseVisualStyleBackColor = false;
            this.UpdateEvaluationButton.Click += new System.EventHandler(this.UpdateEvaluationButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.Gray;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckButton.Location = new System.Drawing.Point(1009, 380);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(130, 56);
            this.CheckButton.TabIndex = 28;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(646, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Check Team Members";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(646, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Update Team Evaluation ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(659, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 69);
            this.label5.TabIndex = 25;
            this.label5.Text = "Welcome Back !";
            // 
            // GetButton
            // 
            this.GetButton.BackColor = System.Drawing.Color.Gray;
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetButton.Location = new System.Drawing.Point(1009, 545);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(130, 59);
            this.GetButton.TabIndex = 31;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = false;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(646, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Get Teams in Specific Project";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftWare_Project.Properties.Resources.Professor_pana;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 649);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoftWare_Project.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AdvisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateEvaluationButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdvisorForm";
            this.Text = "AdvisorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UpdateEvaluationButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}