namespace kursDB
{
    partial class HomeScreen
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
            this.Applicant_button = new System.Windows.Forms.Button();
            this.staff = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Acexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Applicant_button
            // 
            this.Applicant_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Applicant_button.Location = new System.Drawing.Point(12, 313);
            this.Applicant_button.Name = "Applicant_button";
            this.Applicant_button.Size = new System.Drawing.Size(185, 48);
            this.Applicant_button.TabIndex = 0;
            this.Applicant_button.Text = "Соискатели";
            this.Applicant_button.UseVisualStyleBackColor = true;
            this.Applicant_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // staff
            // 
            this.staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staff.Location = new System.Drawing.Point(243, 313);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(185, 48);
            this.staff.TabIndex = 1;
            this.staff.Text = "Заказчик";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(476, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Журнал";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recruitment Agency";
            // 
            // Acexit
            // 
            this.Acexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Acexit.Location = new System.Drawing.Point(12, 9);
            this.Acexit.Name = "Acexit";
            this.Acexit.Size = new System.Drawing.Size(166, 25);
            this.Acexit.TabIndex = 4;
            this.Acexit.Text = "Выйти из аккаунта";
            this.Acexit.UseVisualStyleBackColor = true;
            this.Acexit.Click += new System.EventHandler(this.Acexit_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 397);
            this.Controls.Add(this.Acexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.Applicant_button);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Applicant_button;
        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Acexit;
    }
}