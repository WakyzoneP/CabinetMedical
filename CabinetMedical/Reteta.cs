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
        private readonly string data;
        public Reteta(string medic, string pacient, string diagnostic, string tratament, string data)
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
        public string Data { get => data; }
        public override string ToString()
        {
            return "Medic: " + medic + " Pacient: " + pacient + " Diagnostic: " + diagnostic + " Tratament: " + tratament + " Data: " + data;
        }
    }
}
