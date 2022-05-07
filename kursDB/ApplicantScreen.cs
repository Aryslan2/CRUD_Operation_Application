using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursDB
{
    public partial class ApplicantScreen : Form
    {
        public ApplicantScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen mainsite = new HomeScreen();
            mainsite.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PS744M0\SQLEXPRESS;Initial Catalog=kurs1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        void GetData()
        {
            string query = "SELECT applicant_id, apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres FROM applicant";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgApplicat.DataSource = dt;
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO applicant (apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres) VALUES (@name, @surname, @patronymic, @birthdate, @gender, @contact, @email, @iin, @addres)";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PS744M0\SQLEXPRESS;Initial Catalog=kurs1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@patronymic", txtPatronymic.Text);
            cmd.Parameters.AddWithValue("@birthdate", txtBirthDate.Value);
            cmd.Parameters.AddWithValue("@gender", cmdGender.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@iin", txtIin.Text);
            cmd.Parameters.AddWithValue("@addres", txtAddres.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Соискатель добавлен.");
        }

        private void ApplicantScreen_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dtgApplicat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgApplicat.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dtgApplicat.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dtgApplicat.CurrentRow.Cells[2].Value.ToString();
            txtPatronymic.Text = dtgApplicat.CurrentRow.Cells[3].Value.ToString();
            txtBirthDate.Text = dtgApplicat.CurrentRow.Cells[4].Value.ToString();
            cmdGender.Text = dtgApplicat.CurrentRow.Cells[5].Value.ToString();
            txtContact.Text = dtgApplicat.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dtgApplicat.CurrentRow.Cells[7].Value.ToString();
            txtIin.Text = dtgApplicat.CurrentRow.Cells[8].Value.ToString();
            txtAddres.Text = dtgApplicat.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnupdt_Click(object sender, EventArgs e)
        {
            string query = "UPDATE applicant SET apname=@name, " +
                  "apsurname=@surname, " +
                  "appatronymic=@patronymic, " +
                  "ap_date_of_birth=@birthdate, " +
                  "ap_gender=@gender, " +
                  "apphone=@contact, " +
                  "apmail=@email, " +
                  "apiin=@iin, " +
                  "apaddres=@addres WHERE applicant_id=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@surname", txtSurname.Text);
            cmd.Parameters.AddWithValue("@patronymic", txtPatronymic.Text);
            cmd.Parameters.AddWithValue("@birthdate", txtBirthDate.Value);
            cmd.Parameters.AddWithValue("@gender", cmdGender.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@iin", txtIin.Text);
            cmd.Parameters.AddWithValue("@addres", txtAddres.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            GetData();
            MessageBox.Show("Данные в строке обновлены.");
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM applicant WHERE  applicant_id=@id";
            cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Данные в строке удалены.");
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            if(txtId.Text =="")
                GetData();
            else
            {
                string query = "SELECT applicant_id, apname, apsurname, appatronymic, ap_date_of_birth, ap_gender, apphone, apmail, apiin, apaddres FROM applicant WHERE applicant_id='"+Convert.ToInt32(txtId.Text)+"'";
                con.Open();
                da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgApplicat.DataSource = dt;
                con.Close();
            }
        }

        private void dtgApplicat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Hide();
            Applicant_resume applicant_Resume = new Applicant_resume();
            applicant_Resume.Show();
        }
    }
}
