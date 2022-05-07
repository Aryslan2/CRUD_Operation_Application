namespace kursDB
{
    partial class FormMainJournal
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
            this.cmbJS = new System.Windows.Forms.ComboBox();
            this.txtJId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Заказчик = new System.Windows.Forms.Label();
            this.dtgS = new System.Windows.Forms.DataGridView();
            this.dtgC = new System.Windows.Forms.DataGridView();
            this.dtgApplicant = new System.Windows.Forms.DataGridView();
            this.dtgJM = new System.Windows.Forms.DataGridView();
            this.cmbJC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbJA = new System.Windows.Forms.ComboBox();
            this.dtpJ = new System.Windows.Forms.DateTimePicker();
            this.btncustdlt = new System.Windows.Forms.Button();
            this.btncustupdt = new System.Windows.Forms.Button();
            this.btncustadd = new System.Windows.Forms.Button();
            this.cmbJStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgR = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApplicant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgJM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgR)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbJS
            // 
            this.cmbJS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbJS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbJS.FormattingEnabled = true;
            this.cmbJS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbJS.Location = new System.Drawing.Point(268, 75);
            this.cmbJS.Name = "cmbJS";
            this.cmbJS.Size = new System.Drawing.Size(227, 28);
            this.cmbJS.TabIndex = 67;
            // 
            // txtJId
            // 
            this.txtJId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtJId.Location = new System.Drawing.Point(268, 43);
            this.txtJId.Name = "txtJId";
            this.txtJId.Size = new System.Drawing.Size(227, 26);
            this.txtJId.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(16, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 64;
            this.label11.Text = "Работник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Дата собеседования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Соискатель";
            // 
            // Заказчик
            // 
            this.Заказчик.AutoSize = true;
            this.Заказчик.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Заказчик.Location = new System.Drawing.Point(16, 115);
            this.Заказчик.Name = "Заказчик";
            this.Заказчик.Size = new System.Drawing.Size(80, 20);
            this.Заказчик.TabIndex = 58;
            this.Заказчик.Text = "Заказчик";
            // 
            // dtgS
            // 
            this.dtgS.AllowUserToAddRows = false;
            this.dtgS.AllowUserToDeleteRows = false;
            this.dtgS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgS.Location = new System.Drawing.Point(906, 49);
            this.dtgS.Name = "dtgS";
            this.dtgS.ReadOnly = true;
            this.dtgS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgS.Size = new System.Drawing.Size(457, 202);
            this.dtgS.TabIndex = 68;
            // 
            // dtgC
            // 
            this.dtgC.AllowUserToAddRows = false;
            this.dtgC.AllowUserToDeleteRows = false;
            this.dtgC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgC.Location = new System.Drawing.Point(906, 301);
            this.dtgC.Name = "dtgC";
            this.dtgC.ReadOnly = true;
            this.dtgC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgC.Size = new System.Drawing.Size(457, 195);
            this.dtgC.TabIndex = 69;
            // 
            // dtgApplicant
            // 
            this.dtgApplicant.AllowUserToAddRows = false;
            this.dtgApplicant.AllowUserToDeleteRows = false;
            this.dtgApplicant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgApplicant.Location = new System.Drawing.Point(809, 551);
            this.dtgApplicant.Name = "dtgApplicant";
            this.dtgApplicant.ReadOnly = true;
            this.dtgApplicant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgApplicant.Size = new System.Drawing.Size(318, 195);
            this.dtgApplicant.TabIndex = 70;
            // 
            // dtgJM
            // 
            this.dtgJM.AllowUserToAddRows = false;
            this.dtgJM.AllowUserToDeleteRows = false;
            this.dtgJM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgJM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgJM.Location = new System.Drawing.Point(12, 371);
            this.dtgJM.Name = "dtgJM";
            this.dtgJM.ReadOnly = true;
            this.dtgJM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgJM.Size = new System.Drawing.Size(727, 375);
            this.dtgJM.TabIndex = 71;
            this.dtgJM.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgJM_CellEnter);
            // 
            // cmbJC
            // 
            this.cmbJC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbJC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbJC.FormattingEnabled = true;
            this.cmbJC.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cmbJC.Location = new System.Drawing.Point(268, 109);
            this.cmbJC.Name = "cmbJC";
            this.cmbJC.Size = new System.Drawing.Size(227, 28);
            this.cmbJC.TabIndex = 72;
            this.cmbJC.SelectedIndexChanged += new System.EventHandler(this.cmbJC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Баллы собеседования из 100";
            // 
            // txtJScore
            // 
            this.txtJScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtJScore.Location = new System.Drawing.Point(268, 209);
            this.txtJScore.Name = "txtJScore";
            this.txtJScore.Size = new System.Drawing.Size(227, 26);
            this.txtJScore.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Статус принятия (1-да, 2-нет)";
            // 
            // cmbJA
            // 
            this.cmbJA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbJA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbJA.FormattingEnabled = true;
            this.cmbJA.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cmbJA.Location = new System.Drawing.Point(268, 143);
            this.cmbJA.Name = "cmbJA";
            this.cmbJA.Size = new System.Drawing.Size(227, 28);
            this.cmbJA.TabIndex = 77;
            // 
            // dtpJ
            // 
            this.dtpJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpJ.Location = new System.Drawing.Point(268, 177);
            this.dtpJ.Name = "dtpJ";
            this.dtpJ.Size = new System.Drawing.Size(227, 26);
            this.dtpJ.TabIndex = 78;
            // 
            // btncustdlt
            // 
            this.btncustdlt.Location = new System.Drawing.Point(438, 301);
            this.btncustdlt.Name = "btncustdlt";
            this.btncustdlt.Size = new System.Drawing.Size(96, 36);
            this.btncustdlt.TabIndex = 81;
            this.btncustdlt.Text = "Удалить";
            this.btncustdlt.UseVisualStyleBackColor = true;
            this.btncustdlt.Click += new System.EventHandler(this.btncustdlt_Click);
            // 
            // btncustupdt
            // 
            this.btncustupdt.Location = new System.Drawing.Point(336, 301);
            this.btncustupdt.Name = "btncustupdt";
            this.btncustupdt.Size = new System.Drawing.Size(96, 36);
            this.btncustupdt.TabIndex = 80;
            this.btncustupdt.Text = "Обновить";
            this.btncustupdt.UseVisualStyleBackColor = true;
            this.btncustupdt.Click += new System.EventHandler(this.btncustupdt_Click);
            // 
            // btncustadd
            // 
            this.btncustadd.Location = new System.Drawing.Point(234, 301);
            this.btncustadd.Name = "btncustadd";
            this.btncustadd.Size = new System.Drawing.Size(96, 36);
            this.btncustadd.TabIndex = 79;
            this.btncustadd.Text = "Добавить";
            this.btncustadd.UseVisualStyleBackColor = true;
            this.btncustadd.Click += new System.EventHandler(this.btncustadd_Click);
            // 
            // cmbJStatus
            // 
            this.cmbJStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbJStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbJStatus.FormattingEnabled = true;
            this.cmbJStatus.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbJStatus.Location = new System.Drawing.Point(268, 239);
            this.cmbJStatus.Name = "cmbJStatus";
            this.cmbJStatus.Size = new System.Drawing.Size(227, 28);
            this.cmbJStatus.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(332, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 83;
            this.label6.Text = "Журнал";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 27);
            this.button4.TabIndex = 84;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1042, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 24);
            this.label7.TabIndex = 85;
            this.label7.Text = "Таблица работников";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1047, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 24);
            this.label8.TabIndex = 86;
            this.label8.Text = "Таблица заказчиков";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(851, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 24);
            this.label10.TabIndex = 88;
            this.label10.Text = "Таблица соискателей";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dtgR
            // 
            this.dtgR.AllowUserToAddRows = false;
            this.dtgR.AllowUserToDeleteRows = false;
            this.dtgR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgR.Location = new System.Drawing.Point(1141, 551);
            this.dtgR.Name = "dtgR";
            this.dtgR.ReadOnly = true;
            this.dtgR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgR.Size = new System.Drawing.Size(318, 195);
            this.dtgR.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1199, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 24);
            this.label9.TabIndex = 90;
            this.label9.Text = "Резюме соискателей";
            // 
            // FormMainJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1471, 810);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbJStatus);
            this.Controls.Add(this.btncustdlt);
            this.Controls.Add(this.btncustupdt);
            this.Controls.Add(this.btncustadd);
            this.Controls.Add(this.dtpJ);
            this.Controls.Add(this.cmbJA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJScore);
            this.Controls.Add(this.cmbJC);
            this.Controls.Add(this.dtgJM);
            this.Controls.Add(this.dtgApplicant);
            this.Controls.Add(this.dtgC);
            this.Controls.Add(this.dtgS);
            this.Controls.Add(this.cmbJS);
            this.Controls.Add(this.txtJId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Заказчик);
            this.Name = "FormMainJournal";
            this.Text = "FormMainJournal";
            this.Load += new System.EventHandler(this.FormMainJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApplicant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgJM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJS;
        private System.Windows.Forms.TextBox txtJId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Заказчик;
        private System.Windows.Forms.DataGridView dtgS;
        private System.Windows.Forms.DataGridView dtgC;
        private System.Windows.Forms.DataGridView dtgApplicant;
        private System.Windows.Forms.DataGridView dtgJM;
        private System.Windows.Forms.ComboBox cmbJC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbJA;
        private System.Windows.Forms.DateTimePicker dtpJ;
        private System.Windows.Forms.Button btncustdlt;
        private System.Windows.Forms.Button btncustupdt;
        private System.Windows.Forms.Button btncustadd;
        private System.Windows.Forms.ComboBox cmbJStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgR;
        private System.Windows.Forms.Label label9;
    }
}