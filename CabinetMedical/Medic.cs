using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    internal class Medic
    {
        private String nume { get; set; }
        private String prenume { get; set; }
        private String specializare { get; set; }
        private String telefon { get; set; }
        private String email { get; set; }
        private Int16 varsta { get; set; }
        private String cnp { get; set; }
        private DateTime dataAngajarii { get; set; }
        private Int32 salariul { get; set; }

        public Medic(String nume, String prenume, String specializare, String telefon, String email, int varsta, String cnp, DateTime dataAngajarii, int salariul)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.specializare = specializare;
            this.telefon = telefon;
            this.email = email;
            this.varsta = varsta;
            this.cnp = cnp;
            this.dataAngajarii = dataAngajarii;
            this.salariul = salariul;
        }

        public override string ToString()
        {
            return "Nume: " + nume + " Prenume: " + prenume + " Specializare: " + specializare + " Telefon: " + telefon + " Email: " + email + " Varsta: " + varsta + " CNP: " + cnp + " Data angajarii: " + dataAngajarii + " Salariul: " + salariul;
        }


    }
}
