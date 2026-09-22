using Breza.Helpers;
using Breza.Views;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    [FirestoreData]
    public class IzvjesceDnevno : NotifyingObject
    {
        private string id = Guid.NewGuid().ToString();
        private DateTime datum;
        private string djelatnikId = "";
        private string dnevnaNapomena = "";

        [FirestoreProperty]
        public string Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        [FirestoreProperty]
        public DateTime Datum
        {
            get => datum;
            set => SetProperty(
                      ref datum,
                      DateTime.SpecifyKind(
                          value.Date,
                          DateTimeKind.Utc));
        }

        [FirestoreProperty]
        public string DjelatnikId
        {
            get => djelatnikId;
            set => SetProperty(ref djelatnikId, value);
        }

        [FirestoreProperty]
        public string DnevnaNapomena
        {
            get => dnevnaNapomena;
            set => SetProperty(ref dnevnaNapomena, value);
        }
    }

    //public class IzvjesceDnevno : NotifyingObject
    //{
    //    private DateTime _datum;
    //    private Djelatnik _djelatnik = new Djelatnik();
    //    private string _dnevnaNapomena = string.Empty;
    //    private List<IzvjesceKorisnik> _izvjesceKorisnika = new List<IzvjesceKorisnik>();

    //    public DateTime Datum
    //    {
    //        get => _datum;
    //        set => SetProperty(ref _datum, value);
    //    }

    //    public Djelatnik Djelatnik
    //    {
    //        get => _djelatnik;
    //        set => SetProperty(ref _djelatnik, value);
    //    }

    //    public string DnevnaNapomena
    //    {
    //        get => _dnevnaNapomena;
    //        set => SetProperty(ref _dnevnaNapomena, value);
    //    }

    //    public List<IzvjesceKorisnik> IzvjesceKorisnika
    //    {
    //        get => _izvjesceKorisnika;
    //        set => SetProperty(ref _izvjesceKorisnika, value);
    //    }
    //}
}
