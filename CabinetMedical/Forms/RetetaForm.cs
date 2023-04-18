using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (MedicTextBox.Text == "" || PacientTextBox.Text == "" || DiagnosticTextBox.Text == "" || TratamentTextBox.Text == "" || DataTimePicker.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate!");
            }
            else
            {
                retetaList.Add(new Reteta(MedicTextBox.Text, PacientTextBox.Text, DiagnosticTextBox.Text, TratamentTextBox.Text, DataTimePicker.Value));
                MedicTextBox.Text = "";
                PacientTextBox.Text = "";
                DiagnosticTextBox.Text = "";
                TratamentTextBox.Text = "";
                DataTimePicker.Text = "";
            }
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            using (var file = new System.IO.StreamWriter(@"C:\Users\Public\Documents\reteta.txt"))
            {
                foreach (var reteta in retetaList)
                {
                    file.WriteLine(reteta.ToString());
                }
            }
        }
    }
}
