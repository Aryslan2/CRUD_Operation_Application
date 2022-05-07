namespace kursDB
{
    partial class FormScreenJournal
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
            this.staff = new System.Windows.Forms.Button();
            this.Applicant_button = new System.Windows.Forms.Button();
            this.Acexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staff
            // 
            this.staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staff.Location = new System.Drawing.Point(426, 267);
            this.staff.Name = "staff";
            this.staff.Size = new System.Drawing.Size(185, 48);
            this.staff.TabIndex = 4;
            this.staff.Text = "Журнал подбора соискателей";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // Applicant_button
            // 
            this.Applicant_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Applicant_button.Location = new System.Drawing.Point(85, 267);
            this.Applicant_button.Name = "Applicant_button";
            this.Applicant_button.Size = new System.Drawing.Size(185, 48);
            this.Applicant_button.TabIndex = 3;
            this.Applicant_button.Text = "Список работников";
            this.Applicant_button.UseVisualStyleBackColor = true;
            this.Applicant_button.Click += new System.EventHandler(this.Applicant_button_Click);
            // 
            // Acexit
            // 
            this.Acexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Acexit.Location = new System.Drawing.Point(22, 12);
            this.Acexit.Name = "Acexit";
            this.Acexit.Size = new System.Drawing.Size(95, 25);
            this.Acexit.TabIndex = 6;
            this.Acexit.Text = "Назад";
            this.Acexit.UseVisualStyleBackColor = true;
            this.Acexit.Click += new System.EventHandler(this.Acexit_Click);
            // 
            // FormScreenJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 369);
            this.Controls.Add(this.Acexit);
            this.Controls.Add(this.staff);
            this.Controls.Add(this.Applicant_button);
            this.Name = "FormScreenJournal";
            this.Text = "FormScreenJournal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button staff;
        private System.Windows.Forms.Button Applicant_button;
        private System.Windows.Forms.Button Acexit;
    }
}