using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    public class Djelatnik : NotifyingObject
    {
        private string ime = "";
        private string prezime = "";
        private UserRole ovlasti = UserRole.Odgajatelj;

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

        public UserRole Ovlasti
        {
            get => ovlasti;
            set => SetProperty(ref ovlasti, value);
        }
    }
}
