using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    [Serializable]
    internal class Medic
    {
        public int Id { get; set; }
        public String Nume { get; set; }
        public String Prenume { get; set; }
        public String Specializare { get; set; }
        public String Telefon { get; set; }
        public String Email { get; set; }
        public int Varsta { get; set; }
        public String CNP { get; set; }
        public DateTime DataAngajarii { get; set; }
        public int Salariul { get; set; }

        public Medic(int id = 0, string nume = "Anonim", string prenume = "Anonim", string specializare = "N/A", string telefon = "000000000", string email = "na@na.com", int varsta = 0, string cnp = "00000000", DateTime dataAngajarii = new DateTime(), int salariul = 0)
        {
            this.Id = id;
            this.Nume = nume;
            this.Prenume = prenume;
            this.Specializare = specializare;
            this.Telefon = telefon;
            this.Email = email;
            this.Varsta = varsta;
            this.CNP = cnp;
            this.DataAngajarii = dataAngajarii;
            this.Salariul = salariul;
        }

        public override string ToString()
        {
            return this.Nume + " " + this.Prenume;
        }


    }
}
