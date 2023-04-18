using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    internal class Reteta
    {
        private readonly string medic;
        private readonly string pacient;
        private readonly string diagnostic;
        private readonly string tratament;
        private readonly DateTime data;
        public Reteta(string medic, string pacient, string diagnostic, string tratament, DateTime data)
        {
            this.medic = medic;
            this.pacient = pacient;
            this.diagnostic = diagnostic;
            this.tratament = tratament;
            this.data = data;
        }
        public string Medic { get => medic; }
        public string Pacient { get => pacient; }
        public string Diagnostic { get => diagnostic; }
        public string Tratament { get => tratament; }
        public DateTime Data { get => data; }
        public override string ToString()
        {
            return "Medic: " + medic + "\nPacient: " + pacient + "\nData: " + data.ToLongDateString() + "\nDiagnostic: \n" + diagnostic + "\nTratament: \n" + tratament;
        }
    }
}
