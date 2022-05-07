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
    public partial class FormStaffagenScreen : Form
    {
        public FormStaffagenScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PS744M0\SQLEXPRESS;Initial Catalog=kurs1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        void GetData()
        {
            string query = "SELECT staffagen_id, stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail FROM staffagen";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgStaff.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            FormScreenJournal FormScreenJournal = new FormScreenJournal();
            FormScreenJournal.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormStaffagenScreen_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dtgStaff_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtstufftId.Text = dtgStaff.CurrentRow.Cells[0].Value.ToString();
            txtstuffName.Text = dtgStaff.CurrentRow.Cells[1].Value.ToString();
            txtstuffSurname.Text = dtgStaff.CurrentRow.Cells[2].Value.ToString();
            txtstuffPatronymic.Text = dtgStaff.CurrentRow.Cells[3].Value.ToString();
            txtstuffGender.Text = dtgStaff.CurrentRow.Cells[4].Value.ToString();
            txtstuffContact.Text = dtgStaff.CurrentRow.Cells[5].Value.ToString();
            txtstufftIin.Text = dtgStaff.CurrentRow.Cells[6].Value.ToString();
            txtstuffEmail.Text = dtgStaff.CurrentRow.Cells[7].Value.ToString();
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            if (txtstufftId.Text == "")
                GetData();
            else
            {
                string query = "SELECT staffagen_id, stname, stsurname, stpatronymic, st_gender, stphone, stiin, stmail FROM staffagen WHERE staffagen_id='" + Convert.ToInt32(txtstufftId.Text) + "'";
                con.Open();
                da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgStaff.DataSource = dt;
                con.Close();
            }
        }
    }
}
