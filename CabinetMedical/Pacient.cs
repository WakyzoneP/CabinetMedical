using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    internal class Pacient
    {
        private readonly string name;
        private readonly string prenume;
        private readonly string cnp;
        private readonly string adresa;
        private readonly string telefon;
        private readonly string email;
        private readonly DateTime dataNastere;
        private readonly Int32 varsta;

        public Pacient(string name, string prenume, string cnp, string adresa, string telefon, string email, DateTime dataNastere, Int32 varsta)
        {
            this.name = name;
            this.prenume = prenume;
            this.cnp = cnp;
            this.adresa = adresa;
            this.telefon = telefon;
            this.email = email;
            this.dataNastere = dataNastere;
            this.varsta = varsta;
        }

        public override string ToString()
        {
            return "Nume: " + name + "\nPrenume: " + prenume + "\nVarsta: " + varsta + "\nCNP: " + cnp + "\nAdresa: " + adresa + "\nTelefon: " + telefon + "\nEmail: " + email + "\nData nasterii: " + dataNastere.ToLongDateString() + '\n';
        }
    }
}
