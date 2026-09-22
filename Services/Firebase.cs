using Breza.Helpers;
using Breza.Models;
using Google.Cloud.Firestore;

public class FirebaseService : IDatabase
{
    private readonly FirestoreDb db;

    public FirebaseService()
    {
        string projectId = "breza-e19c7";

        string credentialsPath = Path.Combine(
            AppContext.BaseDirectory,
            "Data",
            "firebase-key.json");

        Environment.SetEnvironmentVariable(
            "GOOGLE_APPLICATION_CREDENTIALS",
            credentialsPath);

        db = FirestoreDb.Create(projectId);
    }
    // =========================================================
    // DJELATNIK
    // =========================================================

    public bool DodajDjelatnika(Djelatnik djelatnik)
    {
        try
        {
            if (djelatnik == null)
                return false;

            DocumentReference doc =
                db.Collection("djelatnici")
                  .Document(djelatnik.Id);

            doc.SetAsync(djelatnik)
               .GetAwaiter()
               .GetResult();

            return true;
        }
        catch
        {
            return false;
        }
    }


    // =========================================================
    // KORISNIK
    // =========================================================

    public bool DodajKorisnika(Korisnik korisnik)
    {
        try
        {
            if (korisnik == null)
                return false;

            DocumentReference doc =
                db.Collection("korisnici")
                  .Document(korisnik.Id);

            doc.SetAsync(korisnik)
               .GetAwaiter()
               .GetResult();

            return true;
        }
        catch
        {
            return false;
        }
    }


    // =========================================================
    // IZVJEŠĆE - DODAJ / AŽURIRAJ
    // =========================================================

    public bool DodajIzvjesce(IzvjesceDnevno izvjesce)
    {
        try
        {
            if (izvjesce == null)
                return false;

            DocumentReference doc =
                db.Collection("izvjesca")
                  .Document(izvjesce.Id);

            doc.SetAsync(izvjesce)
               .GetAwaiter()
               .GetResult();

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
            return false;
        }
    }


    // =========================================================
    // DOHVATI DNEVNO IZVJEŠĆE
    // =========================================================

    public IzvjesceDnevno? DohvatiIzvjesce(
        Djelatnik djelatnik,
        DateTime datum)
    {
        try
        {
            Query query = db
                .Collection("izvjesca")
                .WhereEqualTo(
                    nameof(IzvjesceDnevno.DjelatnikId),
                    djelatnik.Id)
                .WhereEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datum.Date);

            QuerySnapshot snapshot =
                query.GetSnapshotAsync()
                     .GetAwaiter()
                     .GetResult();

            if (snapshot.Count == 0)
                return null;

            return snapshot.Documents[0]
                .ConvertTo<IzvjesceDnevno>();
        }
        catch
        {
            return null;
        }
    }

    // =========================================================
    // IZVJEŠĆE KORISNIKA - SPREMI
    // =========================================================

    public bool SpremiIzvjesceKorisnika(
        IzvjesceKorisnik izvjesceKorisnik)
    {
        try
        {
            if (izvjesceKorisnik == null)
                return false;

            DocumentReference doc =
                db.Collection("izvjescaKorisnika")
                  .Document(izvjesceKorisnik.Id);

            doc.SetAsync(izvjesceKorisnik)
               .GetAwaiter()
               .GetResult();

            return true;
        }
        catch
        {
            return false;
        }
    }


    // =========================================================
    // DOHVATI SVE KORISNIKE
    // =========================================================

    public Korisnik[] DohvatiKorisnike()
    {
        try
        {
            QuerySnapshot snapshot =
                db.Collection("korisnici")
                  .GetSnapshotAsync()
                  .GetAwaiter()
                  .GetResult();

            return snapshot.Documents
                .Select(x => x.ConvertTo<Korisnik>())
                .ToArray();
        }
        catch
        {
            return Array.Empty<Korisnik>();
        }
    }

    // =========================================================
    // DOHVATI JEDNOG KORISNIKA
    // =========================================================

    public Korisnik? DohvatiKorisnika(string korisnikId)
    {
        try
        {
            DocumentReference doc =
                db.Collection("korisnici")
                  .Document(korisnikId);

            DocumentSnapshot snapshot =
                doc.GetSnapshotAsync()
                   .GetAwaiter()
                   .GetResult();

            if (!snapshot.Exists)
                return null;

            return snapshot.ConvertTo<Korisnik>();
        }
        catch
        {
            return null;
        }
    }

    public Djelatnik? Prijava(string ime, string lozinka)
    {
        try
        {
            Query query = db
                .Collection("djelatnici")
                .WhereEqualTo(nameof(Djelatnik.Ime), ime)
                .WhereEqualTo(nameof(Djelatnik.Lozinka), lozinka);

            QuerySnapshot snapshot =
                query.GetSnapshotAsync()
                     .GetAwaiter()
                     .GetResult();

            if (snapshot.Count == 0)
                return null;

            return snapshot.Documents[0]
                .ConvertTo<Djelatnik>();
        }
        catch
        {
            return null;
        }
    }
}