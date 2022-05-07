namespace kursDB
{
    partial class FormStaffagenScreen
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
            this.button4 = new System.Windows.Forms.Button();
            this.dtgStaff = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstufftIin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstuffEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstuffContact = new System.Windows.Forms.TextBox();
            this.txtstufftId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstuffPatronymic = new System.Windows.Forms.TextBox();
            this.txtstuffSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstuffName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstuffGender = new System.Windows.Forms.TextBox();
            this.srchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 27);
            this.button4.TabIndex = 29;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtgStaff
            // 
            this.dtgStaff.AllowUserToAddRows = false;
            this.dtgStaff.AllowUserToDeleteRows = false;
            this.dtgStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStaff.Location = new System.Drawing.Point(12, 45);
            this.dtgStaff.Name = "dtgStaff";
            this.dtgStaff.ReadOnly = true;
            this.dtgStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgStaff.Size = new System.Drawing.Size(815, 451);
            this.dtgStaff.TabIndex = 30;
            this.dtgStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgStaff.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStaff_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Список работников агентства ";
            // 
            // txtstufftIin
            // 
            this.txtstufftIin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtstufftIin.Location = new System.Drawing.Point(944, 320);
            this.txtstufftIin.Name = "txtstufftIin";
            this.txtstufftIin.Size = new System.Drawing.Size(227, 26);
            this.txtstufftIin.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(852, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "ИИН";
            // 
            // txtstuffEmail
            // 
            this.txtstuffEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtstuffEmail.Location = new System.Drawing.Point(944, 366);
            this.txtstuffEmail.Name = "txtstuffEmail";
            this.txtstuffEmail.Size = new System.Drawing.Size(227, 26);
            this.txtstuffEmail.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(852, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(849, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Номер";
            // 
            // txtstuffContact
            // 
            this.txtstuffContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtstuffContact.Location = new System.Drawing.Point(944, 269);
            this.txtstuffContact.Name = "txtstuffContact";
            this.txtstuffContact.Size = new System.Drawing.Size(227, 26);
            this.txtstuffContact.TabIndex = 56;
            // 
            // txtstufftId
            // 
            this.txtstufftId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtstufftId.Location = new System.Drawing.Point(944, 44);
            this.txtstufftId.Name = "txtstufftId";
            this.txtstufftId.Size = new System.Drawing.Size(227, 26);
            this.txtstufftId.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(852, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(849, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Отчество";
            // 
            // txtstuffPatronymic
            // 
            this.txtstuffPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtstuffPatronymic.Location = new System.Drawing.Point(944, 181);
            this.txtstuffPatronymic.Name = "txtstuffPatronymic";
            this.txtstuffPatronymic.Size = new System.Drawing.Size(227, 26);
            this.txtstuffPatronymic.TabIndex = 52;
            // 
            // txtstuffSurname
            // 
            this.txtstuffSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtstuffSurname.Location = new System.Drawing.Point(944, 134);
            this.txtstuffSurname.Name = "txtstuffSurname";
            this.txtstuffSurname.Size = new System.Drawing.Size(227, 26);
            this.txtstuffSurname.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(849, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Фамилия";
            // 
            // txtstuffName
            // 
            this.txtstuffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtstuffName.Location = new System.Drawing.Point(944, 87);
            this.txtstuffName.Name = "txtstuffName";
            this.txtstuffName.Size = new System.Drawing.Size(227, 26);
            this.txtstuffName.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(849, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(852, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Пол";
            // 
            // txtstuffGender
            // 
            this.txtstuffGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtstuffGender.Location = new System.Drawing.Point(944, 222);
            this.txtstuffGender.Name = "txtstuffGender";
            this.txtstuffGender.Size = new System.Drawing.Size(227, 26);
            this.txtstuffGender.TabIndex = 63;
            // 
            // srchbtn
            // 
            this.srchbtn.Location = new System.Drawing.Point(1011, 11);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(100, 23);
            this.srchbtn.TabIndex = 64;
            this.srchbtn.Text = "Искать по ID";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // FormStaffagenScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 514);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.txtstuffGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstufftIin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtstuffEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstuffContact);
            this.Controls.Add(this.txtstufftId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstuffPatronymic);
            this.Controls.Add(this.txtstuffSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstuffName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgStaff);
            this.Controls.Add(this.button4);
            this.Name = "FormStaffagenScreen";
            this.Text = "FormStaffagenScreen";
            this.Load += new System.EventHandler(this.FormStaffagenScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtgStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstufftIin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstuffEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstuffContact;
        private System.Windows.Forms.TextBox txtstufftId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstuffPatronymic;
        private System.Windows.Forms.TextBox txtstuffSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstuffName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstuffGender;
        private System.Windows.Forms.Button srchbtn;
    }
}