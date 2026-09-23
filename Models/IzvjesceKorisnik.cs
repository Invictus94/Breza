using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Breza.Models
{
    [FirestoreData]
    public class IzvjesceKorisnik : NotifyingObject
    {
        private string id = Guid.NewGuid().ToString();
        private string izvjesceId = "";
        private string korisnikId = "";
        private string djelatnikId = "";
        private DateTime datum;
        private KorisnikOcjena ocjena;
        private KorisnikStatus status = KorisnikStatus.U_zajednici;
        private string napomena = "";

        [FirestoreProperty]
        public string Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        [FirestoreProperty]
        public string IzvjesceId
        {
            get => izvjesceId;
            set => SetProperty(ref izvjesceId, value);
        }

        [FirestoreProperty]
        public string DjelatnikId
        {
            get => djelatnikId;
            set => SetProperty(ref djelatnikId, value);
        }

        [FirestoreProperty]
        public string KorisnikId
        {
            get => korisnikId;
            set => SetProperty(ref korisnikId, value);
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
        public KorisnikOcjena Ocjena
        {
            get => ocjena;
            set => SetProperty(ref ocjena, value);
        }

        [FirestoreProperty]
        public KorisnikStatus Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }

        [FirestoreProperty]
        public string Napomena
        {
            get => napomena;
            set => SetProperty(ref napomena, value);
        }
    }
}
