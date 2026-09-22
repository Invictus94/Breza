using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    [FirestoreData]
    public class Korisnik : NotifyingObject
    {
        private string id = Guid.NewGuid().ToString();
        private string ime = "";
        private string prezime = "";

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
    }
    //public class Korisnik : NotifyingObject
    //{
    //    private string ime = "";
    //    private string prezime = "";

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
    //}
}
