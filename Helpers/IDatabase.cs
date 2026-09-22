using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Helpers
{
    public interface IDatabase
    {
        bool DodajKorisnika(string ime, string prezime);
    }
}
