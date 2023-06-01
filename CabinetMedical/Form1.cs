using CabinetMedical.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical
{
    public partial class Form1 : Form
    {
        private string listShow = "";
        private List<Medic> medici = new List<Medic>();
        public Form1()
        {
            InitializeComponent();
            listView.Visible = false;
        }

        private void updateListView()
        {
            if(listShow == "medici")
            {
                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.Add("Id");
                listView.Columns.Add("Nume");
                listView.Columns.Add("Prenume");
                listView.Columns.Add("Specializare");
                listView.Columns.Add("Telefon");
                listView.Columns.Add("Email");
                listView.Columns.Add("Varsta");
                listView.Columns.Add("CNP");
                listView.Columns.Add("Data angajare");
                listView.Columns.Add("Salariul");
                foreach (Medic medic in medici)
                {
                    ListViewItem item = new ListViewItem(medic.Id.ToString());
                    item.SubItems.Add(medic.Nume);
                    item.SubItems.Add(medic.Prenume);
                    item.SubItems.Add(medic.Specializare);
                    item.SubItems.Add(medic.Telefon);
                    item.SubItems.Add(medic.Email);
                    item.SubItems.Add(medic.Varsta.ToString());
                    item.SubItems.Add(medic.CNP.ToString());
                    item.SubItems.Add(medic.DataAngajarii.ToString());
                    item.SubItems.Add(medic.Salariul.ToString());
                    listView.Items.Add(item);
                    updateListView();
                }
            }
        }

        private void MedicButton_Click(object sender, EventArgs e)
        {
            listView.Visible = true;
            listShow = "medici";
            updateListView();
        }

        private void PacientButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RetetaButton_Click(object sender, EventArgs e)
        {
            
        }
        private void medicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicForm medicForm = new MedicForm();
            Medic medic = new Medic();
            medicForm.IdTextBox.Text = medici.Count.ToString();
            medicForm.NumeTextBox.Text = medic.Nume.ToString();
            medicForm.PrenumeTextBox.Text = medic.Prenume.ToString();
            medicForm.SpecializareTextBox.Text = medic.Specializare.ToString();
            medicForm.TelefonTextBox.Text = medic.Telefon.ToString();
            medicForm.EmailTextBox.Text = medic.Email.ToString();
            medicForm.VarstaTextBox.Text = medic.Varsta.ToString();
            medicForm.CNPTextBox.Text = medic.CNP.ToString();
            medicForm.SalariulTextBox.Text = medic.Salariul.ToString();
            DialogResult result = medicForm.ShowDialog();
            if(medicForm.CheckValidation() && result == DialogResult.OK)
            {
                medic.Id = int.Parse(medicForm.IdTextBox.Text);
                medic.Nume = medicForm.NumeTextBox.Text;
                medic.Prenume = medicForm.PrenumeTextBox.Text;
                medic.Specializare = medicForm.SpecializareTextBox.Text;
                medic.Telefon = medicForm.TelefonTextBox.Text;
                medic.Email = medicForm.EmailTextBox.Text;
                medic.Varsta = int.Parse(medicForm.VarstaTextBox.Text);
                medic.CNP = medicForm.CNPTextBox.Text;
                medic.DataAngajarii = medicForm.DataAngajareDateTimePicker.Value;
                medic.Salariul = int.Parse(medicForm.SalariulTextBox.Text);
                medici.Add(medic);
            }

        }

        private void mediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filename = Interaction.InputBox("Introduceti numele fisierului", "Medici", "medici.txt");
        }
    }
}
