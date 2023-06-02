using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabinetMedical.Forms
{
    public partial class PacientForm : Form
    {
        public PacientForm()
        {
            InitializeComponent();
        }

        public bool checkValidation()
        {
            if (NumeTextBox.Text == "" || PrenumeTextBox.Text == "" || CNPTextBox.Text == "" || TelefonTextBox.Text == "" || EmailTextBox.Text == "" || VarstaTextBox.Text == "")
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
                return false;
            }
            if (Regex.Match(NumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Numele trebuie sa contina doar litere!");
                return false;
            }
            if (Regex.Match(PrenumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Prenumele trebuie sa contina doar litere!");
                return false;
            }
            if (Regex.Match(CNPTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("CNP-ul trebuie sa contina doar cifre!");
                return false;
            }
            if (Regex.Match(TelefonTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Telefonul trebuie sa contina doar cifre!");
                return false;
            }
            if (Regex.Match(VarstaTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Varsta trebuie sa contina doar cifre!");
                return false;
            }
            return true;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(NumeTextBox.Text == "" || PrenumeTextBox.Text == "" || CNPTextBox.Text == "" || TelefonTextBox.Text == "" || EmailTextBox.Text == "" || VarstaTextBox.Text == "")
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
            }
            if(Regex.Match(NumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Numele trebuie sa contina doar litere!");
            }
            if (Regex.Match(PrenumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                MessageBox.Show("Prenumele trebuie sa contina doar litere!");
            }
            if (Regex.Match(CNPTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("CNP-ul trebuie sa contina doar cifre!");
            }
            if (Regex.Match(TelefonTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Telefonul trebuie sa contina doar cifre!");
            }
            if (Regex.Match(VarstaTextBox.Text, @"^[0-9]+$").Success == false)
            {
                MessageBox.Show("Varsta trebuie sa contina doar cifre!");
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

        private void PrenumeTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(PrenumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
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
            if(Regex.Match(TelefonTextBox.Text, @"^[0-9]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(EmailTextBox.Text, @"^[a-zA-Z0-9]+$").Success == false)
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

        private void NumeTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(NumeTextBox.Text, @"^[a-zA-Z]+$").Success == false)
            {
                SubmitButton.DialogResult = DialogResult.None;
            }
            else
            {
                SubmitButton.DialogResult = DialogResult.OK;
            }
        }

        Bitmap printBitmap;

        private void printButton_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;

            printBitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(printBitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.PrintPreviewControl.Zoom = 1;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(printBitmap, 0, 0);
        }
    }
}
