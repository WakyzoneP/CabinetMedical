using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CabinetMedical.Forms
{
    public partial class MedicForm : Form
    {
        public MedicForm()
        {
            InitializeComponent();
        }

        public bool checkValidation()
        {
            if (NumeTextBox.Text == "" || PrenumeTextBox.Text == "" || SpecializareTextBox.Text == "" || TelefonTextBox.Text == "" || EmailTextBox.Text == "" || VarstaTextBox.Text == "" || CNPTextBox.Text == "" || DataAngajareDateTimePicker.Text == "" || SalariulTextBox.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate!");
                SubmitButton.DialogResult = DialogResult.None;
                return false;
            }
            if (Regex.Match(NumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Numele trebuie sa contina doar litere!");
                SubmitButton.DialogResult = DialogResult.None;
                return false;
            }
            if (Regex.Match(PrenumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Prenumele trebuie sa contina doar litere!");
                SubmitButton.DialogResult = DialogResult.None;
                return false;
            }
            if (Regex.Match(TelefonTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Numarul de telefon trebuie sa contina doar cifre!");
                SubmitButton.DialogResult = DialogResult.None;
                return false;
            }
            if (Regex.Match(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success == false)
            {
                MessageBox.Show("Email-ul nu este valid!");
                SubmitButton.DialogResult = DialogResult.None;
                return false;
            }
            if (Regex.Match(VarstaTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Varsta trebuie sa contina doar cifre!");
                SubmitButton.DialogResult = DialogResult.None;
                return false;
            }
            if (Regex.Match(CNPTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("CNP-ul trebuie sa contina doar cifre!");
                SubmitButton.DialogResult = DialogResult.None;
                return false;
            }
            if (Regex.Match(SalariulTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Salariul trebuie sa contina doar cifre!");
                SubmitButton.DialogResult = DialogResult.None;
                return false;
            }
            SubmitButton.DialogResult = DialogResult.OK;
            return true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (NumeTextBox.Text == "" || PrenumeTextBox.Text == "" || SpecializareTextBox.Text == "" || TelefonTextBox.Text == "" || EmailTextBox.Text == "" || VarstaTextBox.Text == "" || CNPTextBox.Text == "" || DataAngajareDateTimePicker.Text == "" || SalariulTextBox.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate!");
            }
            if (Regex.Match(NumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Numele trebuie sa contina doar litere!");
            }
            if (Regex.Match(PrenumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Prenumele trebuie sa contina doar litere!");
            }
            if (Regex.Match(TelefonTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Numarul de telefon trebuie sa contina doar cifre!");
            }
            if (Regex.Match(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success == false)
            {
                MessageBox.Show("Email-ul nu este valid!");
            }
            if (Regex.Match(VarstaTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Varsta trebuie sa contina doar cifre!");
            }
            if (Regex.Match(CNPTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("CNP-ul trebuie sa contina doar cifre!");
            }
            if (Regex.Match(SalariulTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Salariul trebuie sa contina doar cifre!");
            }
        }

        private void NumeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(NumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(IdTextBox.Text, @"^[0-9]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void PrenumeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(PrenumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void TelefonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(TelefonTextBox.Text, @"^[0-9]+$").Success == false)
            {
                SubmitButton.DialogResult= DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void VarstaTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(VarstaTextBox.Text, @"^[0-9]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void CNPTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(CNPTextBox.Text, @"^[0-9]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void SalariulTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(SalariulTextBox.Text, @"^[0-9]+$").Success == false)
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
