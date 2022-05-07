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
    public partial class FormScreenJournal : Form
    {
        public FormScreenJournal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Acexit_Click(object sender, EventArgs e)
        {
            Hide();
            HomeScreen mainsite = new HomeScreen();
            mainsite.Show();
        }

        private void Applicant_button_Click(object sender, EventArgs e)
        {
            Hide();
            FormStaffagenScreen FormStaffagenScreen = new FormStaffagenScreen();
            FormStaffagenScreen.Show();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            Hide();
            FormMainJournal FormMainJournal = new FormMainJournal();
            FormMainJournal.Show();
        }
    }
}
