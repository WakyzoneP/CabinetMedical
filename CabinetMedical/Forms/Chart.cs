using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

namespace CabinetMedical.Forms
{
    public partial class Chart : Form
    {
        public List<Pacient> pacienti = new List<Pacient>();
        public Chart()
        {
            InitializeComponent();

        }
        public void SetPacienti(List<Pacient> pacienti) => this.pacienti = pacienti;

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Chart_Load(object sender, EventArgs e)
        {
            int[] intervalVarste = new int[10];
            foreach (Pacient pacient in this.pacienti)
            {
                if (pacient.Varsta < 10) intervalVarste[0] += 1;
                else if (pacient.Varsta < 20) intervalVarste[1] += 1;
                else if (pacient.Varsta < 30) intervalVarste[2] += 1;
                else if (pacient.Varsta < 40) intervalVarste[3] += 1;
                else if (pacient.Varsta < 50) intervalVarste[4] += 1;
                else if (pacient.Varsta < 60) intervalVarste[5] += 1;
                else if (pacient.Varsta < 70) intervalVarste[6] += 1;
                else if (pacient.Varsta < 80) intervalVarste[7] += 1;
                else if (pacient.Varsta < 90) intervalVarste[8] += 1;
            }
            cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LiveCharts.Wpf.ColumnSeries
                {
                    Title = "Ani",
                    Values = new LiveCharts.ChartValues<double> { intervalVarste[0], intervalVarste[1], intervalVarste[2], intervalVarste[3], intervalVarste[4], intervalVarste[5], intervalVarste[6], intervalVarste[7], intervalVarste[8] }
                }
            };
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Varsta",
                Labels = new[] { "10", "20", "30", "40", "50", "60", "70", "80", "90" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Numar de pacienti",
                LabelFormatter = value => value.ToString("N")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }
    }
}
