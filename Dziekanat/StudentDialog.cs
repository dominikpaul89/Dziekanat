using Dziekanat_.Models;
using System;
using System.Windows.Forms;

namespace Dziekanat_
{
    public partial class StudentDialog : Form
    {

        public Student Student { get; set; }
        public StudentDialog()
        {
            InitializeComponent();
        }

        private void anulujButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Student = new Student
            {
                Imie = imieTextBox1.Text,
                Nazwisko = NazwiskoTextBox2.Text,
                IndexNumber = NrIndeksuTextBox3.Text
            };
            Close();
        }

        private void NrIndeksuTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Walidacja IndexNumber
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}

