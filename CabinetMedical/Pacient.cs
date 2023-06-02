using System;

namespace CabinetMedical
{
    [Serializable]
    public class Pacient
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime DataNasterii { get; set; }
        public int Varsta { get; set; }

        public Pacient(int id = 0, string nume = "Anonim", string prenume = "Anonim", string cnp = "0000000000000", string adresa = "Necunoscuta", string telefon = "0000000000", string email = "na@na.com", DateTime dataNasterii = new DateTime(), int varsta = 0)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            Adresa = adresa;
            Telefon = telefon;
            Email = email;
            DataNasterii = dataNasterii;
            Varsta = varsta;
        }

        public override string ToString()
        {
            return Nume + " " + Prenume;
        }
    }
}
