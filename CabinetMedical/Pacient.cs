using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    internal class Pacient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime DataNastere { get; set; }
        public int Varsta { get; set; }

        public Pacient(int id = 0, string name="Anonim", string prenume="Anonim", string cnp="0000000000000", string adresa="Necunoscuta", string telefon="0000000000", string email="na@na.com", DateTime dataNastere=new DateTime(), int varsta=0)
        {
            Id = id;
            Name = name;
            Prenume = prenume;
            CNP = cnp;
            Adresa = adresa;
            Telefon = telefon;
            Email = email;
            DataNastere = dataNastere;
            Varsta = varsta;
        }

        public override string ToString()
        {
            return Name + " " + Prenume;
        }
    }
}
