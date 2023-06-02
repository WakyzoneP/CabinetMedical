using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(printBitmap, 0, 0);
        }
    }
}
