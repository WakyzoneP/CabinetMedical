using CabinetMedical.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CabinetMedical
{
    public partial class Form1 : Form
    {
        private string listShow = "";
        private List<Medic> medici = new List<Medic>();
        private List<Pacient> pacienti = new List<Pacient>();
        private List<Reteta> retete = new List<Reteta>();
        public Form1()
        {
            InitializeComponent();
            listView.Visible = false;
        }

        private void updateListView()
        {
            if (listShow == "medici")
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
                }
            }
            if (listShow == "pacienti")
            {
                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.Add("Id");
                listView.Columns.Add("Nume");
                listView.Columns.Add("Prenume");
                listView.Columns.Add("CNP");
                listView.Columns.Add("Adresa");
                listView.Columns.Add("Telefon");
                listView.Columns.Add("Email");
                listView.Columns.Add("Varsta");
                listView.Columns.Add("Data nastere");
                foreach (Pacient pacient in pacienti)
                {
                    ListViewItem item = new ListViewItem(pacient.Id.ToString());
                    item.SubItems.Add(pacient.Nume);
                    item.SubItems.Add(pacient.Prenume);
                    item.SubItems.Add(pacient.CNP);
                    item.SubItems.Add(pacient.Adresa);
                    item.SubItems.Add(pacient.Telefon);
                    item.SubItems.Add(pacient.Email);
                    item.SubItems.Add(pacient.Varsta.ToString());
                    item.SubItems.Add(pacient.DataNasterii.ToString());
                    listView.Items.Add(item);
                }
            }
            if (listShow == "retete")
            {
                listView.Items.Clear();
                listView.Columns.Clear();
                listView.Columns.Add("Id");
                listView.Columns.Add("Medic");
                listView.Columns.Add("Pacient");
                listView.Columns.Add("Diagnostic");
                listView.Columns.Add("Tratament");
                listView.Columns.Add("Data");
                foreach (Reteta reteta in retete)
                {
                    ListViewItem item = new ListViewItem(reteta.Id.ToString());
                    item.SubItems.Add(reteta.Medic);
                    item.SubItems.Add(reteta.Pacient);
                    item.SubItems.Add(reteta.Diagnostic);
                    item.SubItems.Add(reteta.Tratament);
                    item.SubItems.Add(reteta.Data.ToString());
                    listView.Items.Add(item);
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
            listView.Visible = true;
            listShow = "pacienti";
            updateListView();
        }

        private void RetetaButton_Click(object sender, EventArgs e)
        {
            listView.Visible = true;
            listShow = "retete";
            updateListView();
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
            if (medicForm.checkValidation() && result == DialogResult.OK)
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
                updateListView();
            }
        }

        private void pacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientForm pacientForm = new PacientForm();
            Pacient pacient = new Pacient();
            pacientForm.IdTextBox.Text = pacienti.Count.ToString();
            pacientForm.NumeTextBox.Text = pacient.Nume.ToString();
            pacientForm.PrenumeTextBox.Text = pacient.Prenume.ToString();
            pacientForm.CNPTextBox.Text = pacient.CNP.ToString();
            pacientForm.AdresaTextBox.Text = pacient.Adresa.ToString();
            pacientForm.TelefonTextBox.Text = pacient.Telefon.ToString();
            pacientForm.EmailTextBox.Text = pacient.Email.ToString();
            pacientForm.VarstaTextBox.Text = pacient.Varsta.ToString();
            DialogResult result = pacientForm.ShowDialog();
            if (pacientForm.checkValidation() && result == DialogResult.OK)
            {
                pacient.Id = int.Parse(pacientForm.IdTextBox.Text);
                pacient.Nume = pacientForm.NumeTextBox.Text;
                pacient.Prenume = pacientForm.PrenumeTextBox.Text;
                pacient.CNP = pacientForm.CNPTextBox.Text;
                pacient.Adresa = pacientForm.AdresaTextBox.Text;
                pacient.Telefon = pacientForm.TelefonTextBox.Text;
                pacient.Email = pacientForm.EmailTextBox.Text;
                pacient.Varsta = int.Parse(pacientForm.VarstaTextBox.Text);
                pacient.DataNasterii = pacientForm.DataNasteriiDateTimePicker.Value;
                pacienti.Add(pacient);
                updateListView();
            }
        }

        private void retetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetetaForm retetaForm = new RetetaForm();
            Reteta reteta = new Reteta();
            retetaForm.IdTextBox.Text = retete.Count.ToString();
            retetaForm.MedicTextBox.Text = reteta.Medic.ToString();
            retetaForm.PacientTextBox.Text = reteta.Pacient.ToString();
            retetaForm.DiagnosticTextBox.Text = reteta.Diagnostic.ToString();
            retetaForm.TratamentTextBox.Text = reteta.Tratament.ToString();
            DialogResult result = retetaForm.ShowDialog();
            if (retetaForm.checkValidation() && result == DialogResult.OK)
            {
                reteta.Id = int.Parse(retetaForm.IdTextBox.Text);
                reteta.Medic = retetaForm.MedicTextBox.Text;
                reteta.Pacient = retetaForm.PacientTextBox.Text;
                reteta.Diagnostic = retetaForm.DiagnosticTextBox.Text;
                reteta.Tratament = retetaForm.TratamentTextBox.Text;
                reteta.Data = retetaForm.DataTimePicker.Value;
                retete.Add(reteta);
                updateListView();
            }
        }

        private void mediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String filename = Interaction.InputBox("Introduceti numele fisierului(.dat)", "Medici", "medici.txt");
                FileStream fileStream = new FileStream(filename, FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, medici);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String filename = Interaction.InputBox("Introduceti numele fisierului(.dat)", "Pacienti", "pacienti.txt");
                FileStream fileStream = new FileStream(filename, FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, pacienti);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reteteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String filename = Interaction.InputBox("Introduceti numele fisierului(.dat)", "Retete", "retete.txt");
                FileStream fileStream = new FileStream(filename, FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, retete);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mediciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                String filename = Interaction.InputBox("Introduceti numele fisierului(.dat)", "Medici", "medici.txt");
                FileStream fileStream = new FileStream(filename, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                try
                {
                    medici = (List<Medic>)binaryFormatter.Deserialize(fileStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fileStream.Close();
                updateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pacientiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                String filename = Interaction.InputBox("Introduceti numele fisierului(.dat)", "Pacienti", "pacienti.txt");
                FileStream fileStream = new FileStream(filename, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                try
                {
                    pacienti = (List<Pacient>)binaryFormatter.Deserialize(fileStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fileStream.Close();
                updateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reteteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                String filestream = Interaction.InputBox("Introduceti numele fisierului(.dat)", "Retete", "retete.txt");
                FileStream fileStream = new FileStream(filestream, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                try
                {
                    retete = (List<Reteta>)binaryFormatter.Deserialize(fileStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                fileStream.Close();
                updateListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un element din lista");
                return;
            }
            if(listShow == "medici" && medici.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                int position = item.Index;
                MedicForm medicForm = new MedicForm();
                medicForm.IdTextBox.Text = item.SubItems[0].Text;
                medicForm.NumeTextBox.Text = item.SubItems[1].Text;
                medicForm.PrenumeTextBox.Text = item.SubItems[2].Text;
                medicForm.SpecializareTextBox.Text = item.SubItems[3].Text;
                medicForm.TelefonTextBox.Text = item.SubItems[4].Text;
                medicForm.EmailTextBox.Text = item.SubItems[5].Text;
                medicForm.VarstaTextBox.Text = item.SubItems[6].Text;
                medicForm.CNPTextBox.Text = item.SubItems[7].Text;
                medicForm.DataAngajareDateTimePicker.Value = DateTime.Parse(item.SubItems[8].Text);
                medicForm.SalariulTextBox.Text = item.SubItems[9].Text;
                DialogResult result = medicForm.ShowDialog();
                if(medicForm.checkValidation() && result == DialogResult.OK)
                {
                    medici[position].Id = int.Parse(medicForm.IdTextBox.Text);
                    medici[position].Nume = medicForm.NumeTextBox.Text;
                    medici[position].Prenume = medicForm.PrenumeTextBox.Text;
                    medici[position].Specializare = medicForm.SpecializareTextBox.Text;
                    medici[position].Telefon = medicForm.TelefonTextBox.Text;
                    medici[position].Email = medicForm.EmailTextBox.Text;
                    medici[position].Varsta = int.Parse(medicForm.VarstaTextBox.Text);
                    medici[position].CNP = medicForm.CNPTextBox.Text;
                    medici[position].DataAngajarii = medicForm.DataAngajareDateTimePicker.Value;
                    medici[position].Salariul = int.Parse(medicForm.SalariulTextBox.Text);
                    updateListView();
                }
            }
            if(listShow == "pacienti" && pacienti.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                int position = item.Index;
                PacientForm pacientForm = new PacientForm();
                pacientForm.IdTextBox.Text = item.SubItems[0].Text;
                pacientForm.NumeTextBox.Text = item.SubItems[1].Text;
                pacientForm.PrenumeTextBox.Text = item.SubItems[2].Text;
                pacientForm.CNPTextBox.Text = item.SubItems[3].Text;
                pacientForm.AdresaTextBox.Text = item.SubItems[4].Text;
                pacientForm.TelefonTextBox.Text = item.SubItems[5].Text;
                pacientForm.EmailTextBox.Text = item.SubItems[6].Text;
                pacientForm.VarstaTextBox.Text = item.SubItems[7].Text;
                pacientForm.DataNasteriiDateTimePicker.Value = DateTime.Parse(item.SubItems[8].Text);
                DialogResult result = pacientForm.ShowDialog();
                if(pacientForm.checkValidation() && result == DialogResult.OK)
                {
                    pacienti[position].Id = int.Parse(pacientForm.IdTextBox.Text);
                    pacienti[position].Nume = pacientForm.NumeTextBox.Text;
                    pacienti[position].Prenume = pacientForm.PrenumeTextBox.Text;
                    pacienti[position].CNP = pacientForm.CNPTextBox.Text;
                    pacienti[position].Adresa = pacientForm.AdresaTextBox.Text;
                    pacienti[position].Telefon = pacientForm.TelefonTextBox.Text;
                    pacienti[position].Email = pacientForm.EmailTextBox.Text;
                    pacienti[position].Varsta = int.Parse(pacientForm.VarstaTextBox.Text);
                    pacienti[position].DataNasterii = pacientForm.DataNasteriiDateTimePicker.Value;
                    updateListView();
                }
            }
            if(listShow == "retete" && retete.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                int position = item.Index;
                RetetaForm retetaForm = new RetetaForm();
                retetaForm.IdTextBox.Text = item.SubItems[0].Text;
                retetaForm.MedicTextBox.Text = item.SubItems[1].Text;
                retetaForm.PacientTextBox.Text = item.SubItems[2].Text;
                retetaForm.DiagnosticTextBox.Text = item.SubItems[3].Text;
                retetaForm.TratamentTextBox.Text = item.SubItems[4].Text;
                retetaForm.DataTimePicker.Value = DateTime.Parse(item.SubItems[5].Text);
                DialogResult result = retetaForm.ShowDialog();
                if(retetaForm.checkValidation() && result == DialogResult.OK)
                {
                    retete[position].Id = int.Parse(retetaForm.IdTextBox.Text);
                    retete[position].Medic = retetaForm.MedicTextBox.Text;
                    retete[position].Pacient = retetaForm.PacientTextBox.Text;
                    retete[position].Diagnostic = retetaForm.DiagnosticTextBox.Text;
                    retete[position].Tratament = retetaForm.TratamentTextBox.Text;
                    retete[position].Data = retetaForm.DataTimePicker.Value;
                    updateListView();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati un element din lista");
                return;
            }
            if(listShow == "medici" && medici.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                int position = item.Index;
                medici.RemoveAt(position);
                updateListView();
            }
            if(listShow == "pacienti" && medici.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                int position = item.Index;
                pacienti.RemoveAt(position);
                updateListView();
            }
            if(listShow == "retete" && medici.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];
                int position = item.Index;
                retete.RemoveAt(position);
                updateListView();
            }
        }
    }
}
