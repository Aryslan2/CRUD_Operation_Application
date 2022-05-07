using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursDB
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            ApplicantScreen applicantScreen = new ApplicantScreen();
            applicantScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
        }

        private void Acexit_Click(object sender, EventArgs e)
        {
            Hide();
            login login = new login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormScreenJournal FormScreenJournal = new FormScreenJournal();
            FormScreenJournal.Show();
        }
    }
}
