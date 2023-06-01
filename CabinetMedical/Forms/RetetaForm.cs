using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CabinetMedical.Forms
{
    public partial class RetetaForm : Form
    {
        private readonly List<Reteta> retetaList = new List<Reteta>();
        public RetetaForm()
        {
            InitializeComponent();
        }

        public bool checkValidation()
        {
            if (MedicTextBox.Text == "" || PacientTextBox.Text == "" || DiagnosticTextBox.Text == "" || TratamentTextBox.Text == "" || DataTimePicker.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate!");
                return false;
            }
            if (Regex.Match(MedicTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Numele medicului trebuie sa contina doar litere!");
                return false;
            }
            if (Regex.Match(PacientTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Numele pacientului trebuie sa contina doar litere!");
                return false;
            }
            return true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (MedicTextBox.Text == "" || PacientTextBox.Text == "" || DiagnosticTextBox.Text == "" || TratamentTextBox.Text == "" || DataTimePicker.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate!");
            }
            if (Regex.Match(MedicTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Numele medicului trebuie sa contina doar litere!");
            }
            if (Regex.Match(PacientTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Numele pacientului trebuie sa contina doar litere!");
            }
        }

        private void PacientTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(PacientTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void MedicTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(MedicTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }
    }
}
