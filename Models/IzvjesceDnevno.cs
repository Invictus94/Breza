using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    public class IzvjesceDnevno : NotifyingObject
    {
        private DateTime _datum;
        private Djelatnik _djelatnik = new Djelatnik();
        private string _dnevnaNapomena = string.Empty;
        private List<IzvjesceKorisnik> _izvjesceKorisnika = new List<IzvjesceKorisnik>();

        public DateTime Datum
        {
            get => _datum;
            set => SetProperty(ref _datum, value);
        }

        public Djelatnik Djelatnik
        {
            get => _djelatnik;
            set => SetProperty(ref _djelatnik, value);
        }

        public string DnevnaNapomena
        {
            get => _dnevnaNapomena;
            set => SetProperty(ref _dnevnaNapomena, value);
        }

        public List<IzvjesceKorisnik> IzvjesceKorisnika
        {
            get => _izvjesceKorisnika;
            set => SetProperty(ref _izvjesceKorisnika, value);
        }
    }
}
