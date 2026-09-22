using Breza.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Helpers
{
    public class Core
    {
        public static bool DEBUG =>
#if DEBUG
    true;
#else
            false;
#endif

        public static bool NODB_MODE = true;

        public static Djelatnik CurrentUser;
    }
}
