using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kursDB
{
    public partial class FormMainJournal : Form
    {
        public FormMainJournal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormMainJournal_Load(object sender, EventArgs e)
        {
            GetData();
            GetMata();
            JetMata();
            OetMata();
            BetMata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            FormScreenJournal FormScreenJournal = new FormScreenJournal();
            FormScreenJournal.Show();
        }

        private void cmbJC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PS744M0\SQLEXPRESS;Initial Catalog=kurs1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        void GetData()
        {
            string query = "SELECT candidatlog_id, fk_staffagen, fk_castomer, fk_applicant, date_meeting, scoreme, fk_status FROM candidatlog";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgJM.DataSource = dt;
            con.Close();
        }

        void GetMata()
        {
            string query = "SELECT applicant_id, apname, apsurname FROM applicant";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgApplicant.DataSource = dt;
            con.Close();
        }

        void JetMata()
        {
            string query = "SELECT resum_id, fk_applicant, spec, skill, workex FROM resum";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgR.DataSource = dt;
            con.Close();
        }

        void OetMata()
        {
            string query = "SELECT customer_id, cuname, cusurname, cuiin FROM customer";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgC.DataSource = dt;
            con.Close();
        }

        void BetMata()
        {
            string query = "SELECT staffagen_id, stname, stsurname, stiin FROM staffagen";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgS.DataSource = dt;
            con.Close();
        }

        private void btncustadd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO candidatlog (fk_staffagen, fk_castomer, fk_applicant, date_meeting, scoreme, fk_status) VALUES (@staff, @castomer, @applicant, @date, @score, @status)";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PS744M0\SQLEXPRESS;Initial Catalog=kurs1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@staff", cmbJS.Text);
            cmd.Parameters.AddWithValue("@castomer", cmbJC.Text);
            cmd.Parameters.AddWithValue("@applicant", cmbJA.Text);
            cmd.Parameters.AddWithValue("@date", dtpJ.Value);
            cmd.Parameters.AddWithValue("@score", txtJScore.Text);
            cmd.Parameters.AddWithValue("@status", cmbJStatus.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Запись добавлена.");
        }

        private void btncustupdt_Click(object sender, EventArgs e)
        {
            string query = "UPDATE candidatlog SET fk_staffagen=@staff, " +
                  "fk_castomer=@castomer, " +
                  "fk_applicant=@applicant, " +
                  "date_meeting=@date, " +
                  "scoreme=@score, " +
                  "fk_status=@status WHERE candidatlog_id=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtJId.Text));
            cmd.Parameters.AddWithValue("@staff", cmbJS.Text);
            cmd.Parameters.AddWithValue("@castomer", cmbJC.Text);
            cmd.Parameters.AddWithValue("@applicant", cmbJA.Text);
            cmd.Parameters.AddWithValue("@date", dtpJ.Value);
            cmd.Parameters.AddWithValue("@score", txtJScore.Text);
            cmd.Parameters.AddWithValue("@status", cmbJStatus.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            GetData();
            MessageBox.Show("Данные в строке обновлены.");
        }

        private void dtgJM_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtJId.Text = dtgJM.CurrentRow.Cells[0].Value.ToString();
            cmbJS.Text = dtgJM.CurrentRow.Cells[1].Value.ToString();
            cmbJC.Text = dtgJM.CurrentRow.Cells[2].Value.ToString();
            cmbJA.Text = dtgJM.CurrentRow.Cells[3].Value.ToString();
            dtpJ.Text = dtgJM.CurrentRow.Cells[4].Value.ToString();
            txtJScore.Text = dtgJM.CurrentRow.Cells[5].Value.ToString();
            cmbJStatus.Text = dtgJM.CurrentRow.Cells[6].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btncustdlt_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM candidatlog WHERE  candidatlog_id=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtJId.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Данные в строке удалены.");
        }

    }
}
