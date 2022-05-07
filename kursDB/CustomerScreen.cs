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
    public partial class CustomerScreen : Form
    {
        public CustomerScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string query = "SELECT customer_id, cuname, cusurname, cupatronymic, cuphone, cumail, cuiin FROM customer";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgCustomer.DataSource = dt;
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO customer (cuname, cusurname, cupatronymic, cuphone, cumail, cuiin) VALUES (@cname, @csurname, @cpatronymic,@ccontact, @cemail, @ciin)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@cname", txtcustName.Text);
            cmd.Parameters.AddWithValue("@csurname", txtcustSurname.Text);
            cmd.Parameters.AddWithValue("@cpatronymic", txtcustPatronymic.Text);
            cmd.Parameters.AddWithValue("@ccontact", txtcustContact.Text);
            cmd.Parameters.AddWithValue("@cemail", txtcustEmail.Text);
            cmd.Parameters.AddWithValue("@ciin", txtcustIin.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Заказчик добавлен.");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dtgCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtcustId.Text = dtgCustomer.CurrentRow.Cells[0].Value.ToString();
            txtcustName.Text = dtgCustomer.CurrentRow.Cells[1].Value.ToString();
            txtcustSurname.Text = dtgCustomer.CurrentRow.Cells[2].Value.ToString();
            txtcustPatronymic.Text = dtgCustomer.CurrentRow.Cells[3].Value.ToString();
            txtcustContact.Text = dtgCustomer.CurrentRow.Cells[4].Value.ToString();
            txtcustEmail.Text = dtgCustomer.CurrentRow.Cells[5].Value.ToString();
            txtcustIin.Text = dtgCustomer.CurrentRow.Cells[6].Value.ToString();
        }

        private void btncustupdt_Click(object sender, EventArgs e)
        {
            string query = "UPDATE customer SET cuname=@name, " +
                  "cusurname=@surname, " +
                  "cupatronymic=@patronymic, " +
                  "cuphone=@contact, " +
                  "cumail=@email, " +
                  "cuiin=@iin WHERE customer_id=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtcustId.Text));
            cmd.Parameters.AddWithValue("@name", txtcustName.Text);
            cmd.Parameters.AddWithValue("@surname", txtcustSurname.Text);
            cmd.Parameters.AddWithValue("@patronymic", txtcustPatronymic.Text);
            cmd.Parameters.AddWithValue("@contact", txtcustContact.Text);
            cmd.Parameters.AddWithValue("@email", txtcustEmail.Text);
            cmd.Parameters.AddWithValue("@iin", txtcustIin.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Данные в строке обновлены.");
        }

        private void btncustdlt_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM customer WHERE  customer_id=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtcustId.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Данные в строке удалены.");
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            if (txtcustId.Text == "")
                GetData();
            else
            {
                string query = "SELECT customer_id, cuname, cusurname, cupatronymic, cuphone, cumail, cuiin FROM customer WHERE customer_id='" + Convert.ToInt32(txtcustId.Text) + "'";
                con.Open();
                da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgCustomer.DataSource = dt;
                con.Close();
            }
        }
    }
}
