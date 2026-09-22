using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    [FirestoreData]
    public class Djelatnik : NotifyingObject
    {
        private string id = Guid.NewGuid().ToString();
        private string ime = "";
        private string prezime = "";
        private string lozinka = "";
        private UserRole ovlasti = UserRole.Odgajatelj;

        [FirestoreProperty]
        public string Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        [FirestoreProperty]
        public string Ime
        {
            get => ime;
            set => SetProperty(ref ime, value);
        }

        [FirestoreProperty]
        public string Prezime
        {
            get => prezime;
            set => SetProperty(ref prezime, value);
        }

        [FirestoreProperty]
        public string Lozinka
        {
            get => lozinka;
            set => SetProperty(ref lozinka, value);
        }

        [FirestoreProperty]
        public UserRole Ovlasti
        {
            get => ovlasti;
            set => SetProperty(ref ovlasti, value);
        }
    }

    //public class Djelatnik : NotifyingObject
    //{
    //    private string ime = "";
    //    private string prezime = "";
    //    private UserRole ovlasti = UserRole.Odgajatelj;

    //    public string Ime
    //    {
    //        get => ime;
    //        set => SetProperty(ref ime, value);
    //    }

    //    public string Prezime
    //    {
    //        get => prezime;
    //        set => SetProperty(ref prezime, value);
    //    }

    //    public UserRole Ovlasti
    //    {
    //        get => ovlasti;
    //        set => SetProperty(ref ovlasti, value);
    //    }
    //}
}
