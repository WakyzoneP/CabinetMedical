using System;

namespace CabinetMedical
{
    internal class Reteta
    {
        public int Id { get; set; }
        public string Medic { get; set; }
        public string Pacient { get; set; }
        public string Diagnostic { get; set; }
        public string Tratament { get; set; }
        public DateTime Data { get; set; }
        public Reteta(int id = 0, string medic="Anonim", string pacient ="Anonim", string diagnostic ="N/A", string tratament ="N/A", DateTime data = new DateTime())
        {
            Id = id;
            Medic = medic;
            Pacient = pacient;
            Diagnostic = diagnostic;
            Tratament = tratament;
            Data = data;
        }

        public override string ToString()
        {
            return "Medic: " + Medic + "\nPacient: " + Pacient + "\nDiagnostic: " + Diagnostic + "\nTratament: " + Tratament + "\nData: " + Data.ToString();
        }
    }
}
