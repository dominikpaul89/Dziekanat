using Dziekanat_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziekanat_
{
    public partial class OknoGlowneForm : Form
    {

        public List<Student> Studenci { get; set; } = new List<Student>();
        public OknoGlowneForm()
        {
            InitializeComponent();

            var s1 = new Student()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                IndexNumber = "12345"
            };

            var s2 = new Student()
            {
                Imie = "Anna",
                Nazwisko = "Jantar",
                IndexNumber = "92345"
            };
            Studenci.Add(s1);
            Studenci.Add(s2);

            StudencidataGridView.DataSource = Studenci;
            }

        private void StudencidataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(StudencidataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var st = StudencidataGridView.SelectedRows[0].DataBoundItem as Student;
            imieTextBox1.Text = st.Imie;
            nazwiskoTextBox2.Text = st.Nazwisko;
        }

 

        private void dodajButton1_Click_1(object sender, EventArgs e)
        {
            var dialog = new StudentDialog();
            dialog.ShowDialog();

            if (dialog.Student != null)
            {
                Studenci.Add(dialog.Student);
                StudencidataGridView.DataSource = null;
                StudencidataGridView.DataSource = Studenci;
            }
        }

        private void Usun_Click(object sender, EventArgs e)
        {
        
                Studenci.RemoveAt(StudencidataGridView.SelectedRows[0].Index);
                  StudencidataGridView.DataSource = null;
                  StudencidataGridView.DataSource = Studenci;

        }
        
        }
    }

