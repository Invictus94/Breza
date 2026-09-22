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
    }
}
