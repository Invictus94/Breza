using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    public class IzvjesceKorisnik : NotifyingObject
    {
        private Korisnik _korisnik = new Korisnik();
        private string _napomena = string.Empty;
        private KorisnikStatus _korisnikStatus;
        private KorisnikOcjena _korisnikOcjena;

        public Korisnik Korisnik
        {
            get => _korisnik;
            set => SetProperty(ref _korisnik, value);
        }

        public string Napomena
        {
            get => _napomena;
            set => SetProperty(ref _napomena, value);
        }

        public KorisnikStatus KorisnikStatus
        {
            get => _korisnikStatus;
            set => SetProperty(ref _korisnikStatus, value);
        }

        public KorisnikOcjena KorisnikOcjena
        {
            get => _korisnikOcjena;
            set => SetProperty(ref _korisnikOcjena, value);
        }
    }
}
