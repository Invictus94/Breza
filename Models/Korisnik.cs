using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    public class Korisnik : NotifyingObject
    {
        private string ime = "";
        private string prezime = "";

        public string Ime
        {
            get => ime;
            set => SetProperty(ref ime, value);
        }

        public string Prezime
        {
            get => prezime;
            set => SetProperty(ref prezime, value);
        }
    }
}
