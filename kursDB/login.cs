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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PS744M0\SQLEXPRESS;Initial Catalog=kurs1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Regist where log_user=@username and pass_user =@userpass", con);
            cmd.Parameters.AddWithValue("@username", textLogin.Text);
            cmd.Parameters.AddWithValue("@userpass", textPass.Text);

            con.Open();

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Hide();
                HomeScreen mainsite = new HomeScreen();
                mainsite.Show();
                
            }
            else
            {
                MessageBox.Show("Введены неправильные  данные, попробуйте ещё раз!");
            }

            con.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
