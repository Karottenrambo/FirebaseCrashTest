using Firebase.Firestore;

[FirestoreData]

public struct FirestoreTestData
{
    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public string Description { get; set; }

    [FirestoreProperty]
    public int Attack { get; set; }

    [FirestoreProperty]
    public int Defense { get; set; }
}
