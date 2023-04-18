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
    public partial class PacientForm : Form
    {
        private readonly List<Pacient> pacientList = new List<Pacient>();
        public PacientForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(NumeTextBox.Text == "" || PrenumeTextBox.Text == "" || CNPTextBox.Text == "" || AdresaTextBox.Text == "" || TelefonTextBox.Text == "" || EmailTextBox.Text == "" || DataNasteriiDateTimePicker.Text == "" || VarstaTextBox.Text == "")
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
            }
            else
            {
                pacientList.Add(new Pacient(NumeTextBox.Text, PrenumeTextBox.Text, CNPTextBox.Text, AdresaTextBox.Text, TelefonTextBox.Text, EmailTextBox.Text, Convert.ToDateTime(DataNasteriiDateTimePicker.Value), Convert.ToInt32(VarstaTextBox.Text)));
                NumeTextBox.Text = "";
                PrenumeTextBox.Text = "";
                CNPTextBox.Text = "";
                AdresaTextBox.Text = "";
                TelefonTextBox.Text = "";
                EmailTextBox.Text = "";
                DataNasteriiDateTimePicker.Text = "";
                VarstaTextBox.Text = "";
            }
        }

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            using(var file = new System.IO.StreamWriter(@"C:\Users\Public\Documents\pacient.txt"))
            {
                foreach(var pacient in pacientList)
                {
                    file.WriteLine(pacient.ToString());
                }
            }
        }
    }
}
