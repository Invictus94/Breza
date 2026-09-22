using Google.Cloud.Firestore;

public class FirebaseService
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

    public async Task TestAsync()
    {
        var docRef = db
            .Collection("test")
            .Document("test1");

        await docRef.SetAsync(new
        {
            poruka = "Radi!",
            datum = DateTime.UtcNow
        });
    }
}