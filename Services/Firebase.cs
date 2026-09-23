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

    private DateTime setDateUtc(DateTime date)
    {
        return DateTime.SpecifyKind(
           date,
           DateTimeKind.Utc);
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
    // IZVJEŠĆE KORISNIKA - SPREMI
    // =========================================================

    public bool DodajIzvjesceKorisnika(
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

    private Izvjesce[] SpojiIzvjesca(
    IEnumerable<IzvjesceDnevno> dnevnaIzvjesca,
    IEnumerable<IzvjesceKorisnik> korisnici)
    {
        var korisniciPoIzvjescu = korisnici
            .GroupBy(x => x.IzvjesceId)
            .ToDictionary(
                x => x.Key,
                x => x.ToList());

        return dnevnaIzvjesca
            .Select(x => new Izvjesce
            {
                Id = x.Id,
                Datum = x.Datum,
                DjelatnikId = x.DjelatnikId,
                DnevnaNapomena = x.DnevnaNapomena,

                Korisnici = korisniciPoIzvjescu.TryGetValue(
                    x.Id,
                    out var lista)
                        ? lista
                        : new List<IzvjesceKorisnik>()
            })
            .ToArray();
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

    public Djelatnik[] DohvatiDjelatnike()
    {
        try
        {
            QuerySnapshot snapshot =
                db.Collection("djelatnici")
                  .GetSnapshotAsync()
                  .GetAwaiter()
                  .GetResult();

            return snapshot.Documents
                .Select(x => x.ConvertTo<Djelatnik>())
                .ToArray();
        }
        catch
        {
            return Array.Empty<Djelatnik>();
        }
    }
    public Izvjesce[] DohvatiIzvjesce(
Djelatnik djelatnik,
DateTime from,
DateTime to)
    {
        return DohvatiIzvjesce(
            djelatnik,
            from,
            to,
            null);
    }
    public Izvjesce[] DohvatiIzvjesce(
        Djelatnik djelatnik,
        DateTime from,
        DateTime to,
        IzvjesceStatus? status)
    {
        try
        {
            DateTime datumOd = setDateUtc(from);
            DateTime datumDo = setDateUtc(to);

            Query dnevniQuery = db
                .Collection("izvjesca")
                .WhereEqualTo(
                    nameof(IzvjesceDnevno.DjelatnikId),
                    djelatnik.Id)
                .WhereGreaterThanOrEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datumOd)
                .WhereLessThanOrEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datumDo);

            if (status.HasValue)
            {
                dnevniQuery = dnevniQuery.WhereEqualTo(
                    nameof(IzvjesceDnevno.Status),
                    (int)status.Value);
            }

            QuerySnapshot dnevniSnapshot = dnevniQuery
                .GetSnapshotAsync()
                .GetAwaiter()
                .GetResult();

            var dnevnaIzvjesca = dnevniSnapshot.Documents
                .Select(x => x.ConvertTo<IzvjesceDnevno>())
                .ToArray();

            if (dnevnaIzvjesca.Length == 0)
                return Array.Empty<Izvjesce>();

            var izvjesceIds = dnevnaIzvjesca
                .Select(x => x.Id)
                .ToHashSet();

            Query korisniciQuery = db
     .Collection("izvjescaKorisnika")
     .WhereEqualTo(
         nameof(IzvjesceKorisnik.DjelatnikId),
         djelatnik.Id)
     .WhereGreaterThanOrEqualTo(
         nameof(IzvjesceKorisnik.Datum),
         datumOd)
     .WhereLessThanOrEqualTo(
         nameof(IzvjesceKorisnik.Datum),
         datumDo);

            QuerySnapshot korisniciSnapshot = korisniciQuery
                .GetSnapshotAsync()
                .GetAwaiter()
                .GetResult();

            var korisnici = korisniciSnapshot.Documents
                .Select(x => x.ConvertTo<IzvjesceKorisnik>())
                .Where(x => izvjesceIds.Contains(x.IzvjesceId))
                .ToArray();

            return SpojiIzvjesca(
                dnevnaIzvjesca,
                korisnici);
        }
        catch (Exception e)
        {
            if (Core.THROWEXCEPTIONS)
                MessageBox.Show(e.Message);

            return Array.Empty<Izvjesce>();
        }
    }
    public Izvjesce[] DohvatiIzvjesce(
        Djelatnik djelatnik,
        Korisnik korisnik,
        DateTime from,
        DateTime to)
    {
        return DohvatiIzvjesce(
             djelatnik,
             korisnik,
             from,
             to,
             null);
    }

    public Izvjesce[] DohvatiIzvjesce(
        Djelatnik djelatnik,
        Korisnik korisnik,
        DateTime from,
        DateTime to,
        IzvjesceStatus? status)
    {
        try
        {
            DateTime datumOd = setDateUtc(from);
            DateTime datumDo = setDateUtc(to);

            Query dnevniQuery = db
                .Collection("izvjesca")
                .WhereEqualTo(
                    nameof(IzvjesceDnevno.DjelatnikId),
                    djelatnik.Id)
                .WhereGreaterThanOrEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datumOd)
                .WhereLessThanOrEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datumDo);

            if (status.HasValue)
            {
                dnevniQuery = dnevniQuery.WhereEqualTo(
                    nameof(IzvjesceDnevno.Status),
                    (int)status.Value);
            }

            QuerySnapshot dnevniSnapshot = dnevniQuery
                .GetSnapshotAsync()
                .GetAwaiter()
                .GetResult();

            var dnevnaIzvjesca = dnevniSnapshot.Documents
                .Select(x => x.ConvertTo<IzvjesceDnevno>())
                .ToArray();

            if (dnevnaIzvjesca.Length == 0)
                return Array.Empty<Izvjesce>();

            var izvjesceIds = dnevnaIzvjesca
                .Select(x => x.Id)
                .ToHashSet();

            Query korisniciQuery = db
                .Collection("izvjescaKorisnika")
                .WhereEqualTo(
                    nameof(IzvjesceKorisnik.DjelatnikId),
                    djelatnik.Id)
                .WhereEqualTo(
                    nameof(IzvjesceKorisnik.KorisnikId),
                    korisnik.Id)
                .WhereGreaterThanOrEqualTo(
                    nameof(IzvjesceKorisnik.Datum),
                    datumOd)
                .WhereLessThanOrEqualTo(
                    nameof(IzvjesceKorisnik.Datum),
                    datumDo);

            QuerySnapshot korisniciSnapshot = korisniciQuery
                .GetSnapshotAsync()
                .GetAwaiter()
                .GetResult();

            var korisnici = korisniciSnapshot.Documents
                .Select(x => x.ConvertTo<IzvjesceKorisnik>())
                .Where(x => izvjesceIds.Contains(x.IzvjesceId))
                .ToArray();

            return SpojiIzvjesca(
                dnevnaIzvjesca,
                korisnici);
        }
        catch (Exception e)
        {
            if (Core.THROWEXCEPTIONS)
                MessageBox.Show(e.Message);

            return Array.Empty<Izvjesce>();
        }
    }

    public Izvjesce[] DohvatiIzvjesce(
        Korisnik korisnik,
        DateTime from,
        DateTime to)
    {
        return DohvatiIzvjesce(
            korisnik,
            from,
            to,
            null);
    }

    public Izvjesce[] DohvatiIzvjesce(
        Korisnik korisnik,
        DateTime from,
        DateTime to,
        IzvjesceStatus? status)
    {
        try
        {
            DateTime datumOd = setDateUtc(from);
            DateTime datumDo = setDateUtc(to);

            Query korisniciQuery = db
                .Collection("izvjescaKorisnika")
                .WhereEqualTo(
                    nameof(IzvjesceKorisnik.KorisnikId),
                    korisnik.Id)
                .WhereGreaterThanOrEqualTo(
                    nameof(IzvjesceKorisnik.Datum),
                    datumOd)
                .WhereLessThanOrEqualTo(
                    nameof(IzvjesceKorisnik.Datum),
                    datumDo);

            QuerySnapshot korisniciSnapshot = korisniciQuery
                .GetSnapshotAsync()
                .GetAwaiter()
                .GetResult();

            var korisnici = korisniciSnapshot.Documents
                .Select(x => x.ConvertTo<IzvjesceKorisnik>())
                .ToArray();

            if (korisnici.Length == 0)
                return Array.Empty<Izvjesce>();

            var izvjesceIds = korisnici
                .Select(x => x.IzvjesceId)
                .Distinct()
                .ToHashSet();

            Query dnevniQuery = db
                .Collection("izvjesca")
                .WhereGreaterThanOrEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datumOd)
                .WhereLessThanOrEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datumDo);

            if (status.HasValue)
            {
                dnevniQuery = dnevniQuery.WhereEqualTo(
                    nameof(IzvjesceDnevno.Status),
                    (int)status.Value);
            }

            QuerySnapshot dnevniSnapshot = dnevniQuery
                .GetSnapshotAsync()
                .GetAwaiter()
                .GetResult();

            var dnevnaIzvjesca = dnevniSnapshot.Documents
                .Select(x => x.ConvertTo<IzvjesceDnevno>())
                .Where(x => izvjesceIds.Contains(x.Id))
                .ToArray();

            return SpojiIzvjesca(
                dnevnaIzvjesca,
                korisnici);
        }
        catch (Exception e)
        {
            if (Core.THROWEXCEPTIONS)
                MessageBox.Show(e.Message);

            return Array.Empty<Izvjesce>();
        }
    }

    public Izvjesce[] DohvatiIzvjesce(
        DateTime from,
        DateTime to)
    {
        return DohvatiIzvjesce(
            from,
            to,
            null);
    }

    public Izvjesce[] DohvatiIzvjesce(
        DateTime from,
        DateTime to,
        IzvjesceStatus? status)
    {
        try
        {
            DateTime datumOd = setDateUtc(from);
            DateTime datumDo = setDateUtc(to);

            Query dnevniQuery = db
                .Collection("izvjesca")
                .WhereGreaterThanOrEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datumOd)
                .WhereLessThanOrEqualTo(
                    nameof(IzvjesceDnevno.Datum),
                    datumDo);

            if (status.HasValue)
            {
                dnevniQuery = dnevniQuery.WhereEqualTo(
                    nameof(IzvjesceDnevno.Status),
                    (int)status.Value);
            }

            QuerySnapshot dnevniSnapshot = dnevniQuery
                .GetSnapshotAsync()
                .GetAwaiter()
                .GetResult();

            var dnevnaIzvjesca = dnevniSnapshot.Documents
                .Select(x => x.ConvertTo<IzvjesceDnevno>())
                .ToArray();

            if (dnevnaIzvjesca.Length == 0)
                return Array.Empty<Izvjesce>();

            var izvjesceIds = dnevnaIzvjesca
                .Select(x => x.Id)
                .ToHashSet();

            Query korisniciQuery = db
                .Collection("izvjescaKorisnika")
                .WhereGreaterThanOrEqualTo(
                    nameof(IzvjesceKorisnik.Datum),
                    datumOd)
                .WhereLessThanOrEqualTo(
                    nameof(IzvjesceKorisnik.Datum),
                    datumDo);

            QuerySnapshot korisniciSnapshot = korisniciQuery
                .GetSnapshotAsync()
                .GetAwaiter()
                .GetResult();

            var korisnici = korisniciSnapshot.Documents
                .Select(x => x.ConvertTo<IzvjesceKorisnik>())
                .Where(x => izvjesceIds.Contains(x.IzvjesceId))
                .ToArray();

            return SpojiIzvjesca(
                dnevnaIzvjesca,
                korisnici);
        }
        catch (Exception e)
        {
            if (Core.THROWEXCEPTIONS)
                MessageBox.Show(e.Message);

            return Array.Empty<Izvjesce>();
        }
    }
}