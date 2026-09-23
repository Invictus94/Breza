using Breza.Models;
using Google.Cloud.Firestore.V1;
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

        public static bool NODB_MODE = false;
        public static bool NOLOGIN_MODE = false;
        public static bool THROWEXCEPTIONS = true;





        public static Djelatnik CurrentUser;
        public static IDatabase Database = new FirebaseService();

        public static string GetNewID => Guid.NewGuid().ToString();
    }
}
