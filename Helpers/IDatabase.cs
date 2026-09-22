using Breza.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Helpers
{
    public interface IDatabase
    {
        bool DodajDjelatnika(Djelatnik djelatnik);
        bool DodajKorisnika(Korisnik korisnik);
        Korisnik[] DohvatiKorisnike();
        IzvjesceDnevno? DohvatiIzvjesce(Djelatnik djelatnik, DateTime datum);
        bool DodajIzvjesce(IzvjesceDnevno izvjesce);
        Korisnik? DohvatiKorisnika(string korisnikId);
        bool SpremiIzvjesceKorisnika(IzvjesceKorisnik izvjesceKorisnik);
        Djelatnik? Prijava(string ime, string lozinka);
    }
}
