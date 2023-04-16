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
        private readonly string surname;
        private readonly string cnp;
        private readonly string address;
        private readonly string phone;
        private readonly string email;
        private readonly string phoneNumber;
        private readonly string birthDate;

        public Pacient(string name, string surname, string cnp, string address, string phone, string email, string phoneNumber, string birthDate)
        {
            this.name = name;
            this.surname = surname;
            this.cnp = cnp;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.birthDate = birthDate;
        }

        public string Name { get => name; }
        public string Surname { get => surname; }
        public string Cnp { get => cnp; }
        public string Address { get => address; }
        public string Phone { get => phone; }
        public string Email { get => email; }
        public string PhoneNumber { get => phoneNumber; }
        public string BirthDate { get => birthDate; }

        public override string ToString()
        {
            return "Nume: " + name + " Prenume: " + surname + " CNP: " + cnp + " Adresa: " + address + " Telefon: " + phone + " Email: " + email + " Numar Telefon: " + phoneNumber + " Data Nasterii: " + birthDate;
        }
    }
}
