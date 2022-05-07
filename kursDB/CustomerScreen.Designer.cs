namespace kursDB
{
    partial class CustomerScreen
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
            this.srchbtn = new System.Windows.Forms.Button();
            this.txtcustId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustPatronymic = new System.Windows.Forms.TextBox();
            this.txtcustSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcustName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcustIin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcustEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcustContact = new System.Windows.Forms.TextBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btncustdlt = new System.Windows.Forms.Button();
            this.btncustupdt = new System.Windows.Forms.Button();
            this.btncustadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // srchbtn
            // 
            this.srchbtn.Location = new System.Drawing.Point(342, 44);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(70, 23);
            this.srchbtn.TabIndex = 41;
            this.srchbtn.Text = "Искать";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // txtcustId
            // 
            this.txtcustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcustId.Location = new System.Drawing.Point(109, 41);
            this.txtcustId.Name = "txtcustId";
            this.txtcustId.Size = new System.Drawing.Size(227, 26);
            this.txtcustId.TabIndex = 40;
            this.txtcustId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(17, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Отчество";
            // 
            // txtcustPatronymic
            // 
            this.txtcustPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcustPatronymic.Location = new System.Drawing.Point(109, 178);
            this.txtcustPatronymic.Name = "txtcustPatronymic";
            this.txtcustPatronymic.Size = new System.Drawing.Size(227, 26);
            this.txtcustPatronymic.TabIndex = 36;
            // 
            // txtcustSurname
            // 
            this.txtcustSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcustSurname.Location = new System.Drawing.Point(109, 131);
            this.txtcustSurname.Name = "txtcustSurname";
            this.txtcustSurname.Size = new System.Drawing.Size(227, 26);
            this.txtcustSurname.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Фамилия";
            // 
            // txtcustName
            // 
            this.txtcustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcustName.Location = new System.Drawing.Point(109, 84);
            this.txtcustName.Name = "txtcustName";
            this.txtcustName.Size = new System.Drawing.Size(227, 26);
            this.txtcustName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Имя";
            // 
            // txtcustIin
            // 
            this.txtcustIin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcustIin.Location = new System.Drawing.Point(109, 278);
            this.txtcustIin.Name = "txtcustIin";
            this.txtcustIin.Size = new System.Drawing.Size(227, 26);
            this.txtcustIin.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "ИИН";
            // 
            // txtcustEmail
            // 
            this.txtcustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcustEmail.Location = new System.Drawing.Point(109, 324);
            this.txtcustEmail.Name = "txtcustEmail";
            this.txtcustEmail.Size = new System.Drawing.Size(227, 26);
            this.txtcustEmail.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(17, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Номер";
            // 
            // txtcustContact
            // 
            this.txtcustContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcustContact.Location = new System.Drawing.Point(109, 227);
            this.txtcustContact.Name = "txtcustContact";
            this.txtcustContact.Size = new System.Drawing.Size(227, 26);
            this.txtcustContact.TabIndex = 42;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.AllowUserToAddRows = false;
            this.dtgCustomer.AllowUserToDeleteRows = false;
            this.dtgCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(443, 41);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.ReadOnly = true;
            this.dtgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCustomer.Size = new System.Drawing.Size(713, 298);
            this.dtgCustomer.TabIndex = 48;
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgCustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellEnter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 27);
            this.button4.TabIndex = 49;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btncustdlt
            // 
            this.btncustdlt.Location = new System.Drawing.Point(1063, 383);
            this.btncustdlt.Name = "btncustdlt";
            this.btncustdlt.Size = new System.Drawing.Size(96, 36);
            this.btncustdlt.TabIndex = 52;
            this.btncustdlt.Text = "Удалить";
            this.btncustdlt.UseVisualStyleBackColor = true;
            this.btncustdlt.Click += new System.EventHandler(this.btncustdlt_Click);
            // 
            // btncustupdt
            // 
            this.btncustupdt.Location = new System.Drawing.Point(961, 383);
            this.btncustupdt.Name = "btncustupdt";
            this.btncustupdt.Size = new System.Drawing.Size(96, 36);
            this.btncustupdt.TabIndex = 51;
            this.btncustupdt.Text = "Обновить";
            this.btncustupdt.UseVisualStyleBackColor = true;
            this.btncustupdt.Click += new System.EventHandler(this.btncustupdt_Click);
            // 
            // btncustadd
            // 
            this.btncustadd.Location = new System.Drawing.Point(859, 383);
            this.btncustadd.Name = "btncustadd";
            this.btncustadd.Size = new System.Drawing.Size(96, 36);
            this.btncustadd.TabIndex = 50;
            this.btncustadd.Text = "Добавить";
            this.btncustadd.UseVisualStyleBackColor = true;
            this.btncustadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 450);
            this.Controls.Add(this.btncustdlt);
            this.Controls.Add(this.btncustupdt);
            this.Controls.Add(this.btncustadd);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.txtcustIin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcustEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcustContact);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.txtcustId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcustPatronymic);
            this.Controls.Add(this.txtcustSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcustName);
            this.Controls.Add(this.label1);
            this.Name = "CustomerScreen";
            this.Text = "CustomerScreen";
            this.Load += new System.EventHandler(this.CustomerScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox txtcustId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustPatronymic;
        private System.Windows.Forms.TextBox txtcustSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcustIin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcustEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcustContact;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btncustdlt;
        private System.Windows.Forms.Button btncustupdt;
        private System.Windows.Forms.Button btncustadd;
    }
}