using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    public class Izvjesce : IzvjesceDnevno
    {
        public List<IzvjesceKorisnik> Korisnici { get; set; } 
    }
}
