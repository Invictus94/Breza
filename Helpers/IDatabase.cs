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
        bool DodajIzvjesce(IzvjesceDnevno izvjesce);
        bool DodajIzvjesceKorisnika(IzvjesceKorisnik izvjesceKorisnik);

        Korisnik[] DohvatiKorisnike();
        Djelatnik[] DohvatiDjelatnike();
        Izvjesce[]? DohvatiIzvjesce(Djelatnik djelatnik, DateTime from, DateTime to);
        Izvjesce[]? DohvatiIzvjesce(Djelatnik djelatnik, DateTime from, DateTime to, IzvjesceStatus? status);
        Izvjesce[]? DohvatiIzvjesce(Djelatnik djelatnik, Korisnik korisnik, DateTime from, DateTime to);
        Izvjesce[]? DohvatiIzvjesce(Djelatnik djelatnik, Korisnik korisnik, DateTime from, DateTime to, IzvjesceStatus? status);
        Izvjesce[]? DohvatiIzvjesce(Korisnik korisnik, DateTime from, DateTime to);
        Izvjesce[]? DohvatiIzvjesce(Korisnik korisnik, DateTime from, DateTime to, IzvjesceStatus? status);
        Izvjesce[]? DohvatiIzvjesce(DateTime from, DateTime to);
        Izvjesce[]? DohvatiIzvjesce(DateTime from, DateTime to, IzvjesceStatus? status);
        Korisnik? DohvatiKorisnika(string korisnikId);

        Djelatnik? Prijava(string ime, string lozinka);
    }
}
