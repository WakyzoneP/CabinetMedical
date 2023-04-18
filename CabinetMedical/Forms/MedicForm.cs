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
    public partial class MedicForm : Form
    {
        private readonly List<Medic> medicList = new List<Medic>();
        public MedicForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(NumeTextBox.Text == "" || PrenumeTextBox.Text == "" || SpecializareTextBox.Text == "" || TelefonTextBox.Text == "" || EmailTextBox.Text == "" || VarstaTextBox.Text == "" || CNPTextBox.Text == "" || DataAngajareDateTimePicker.Text == "" || SalariulTextBox.Text == "")
            {
                MessageBox.Show("Toate campurile trebuie completate!");
            }
            else
            {
                medicList.Add(new Medic(NumeTextBox.Text, PrenumeTextBox.Text, SpecializareTextBox.Text, TelefonTextBox.Text, EmailTextBox.Text, Convert.ToInt16(VarstaTextBox.Text), CNPTextBox.Text, Convert.ToDateTime(DataAngajareDateTimePicker.Value), Convert.ToInt32(SalariulTextBox.Text)));
                NumeTextBox.Text = "";
                PrenumeTextBox.Text = "";
                SpecializareTextBox.Text = "";
                TelefonTextBox.Text = "";
                EmailTextBox.Text = "";
                VarstaTextBox.Text = "";
                CNPTextBox.Text = "";
                DataAngajareDateTimePicker.Text = "";
                SalariulTextBox.Text = "";
            }
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            using (var file = new System.IO.StreamWriter(@"C:\Users\Public\Documents\medic.txt"))
            {
                foreach (var medic in medicList)
                {
                    file.WriteLine(medic.ToString());
                }
            }
        }
    }
}
