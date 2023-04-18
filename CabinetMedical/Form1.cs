﻿using System;
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
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MedicButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MedicForm(), sender);
        }

        private void PacientButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PacientForm(), sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RetetaButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RetetaForm(), sender);
        }
    }
}
