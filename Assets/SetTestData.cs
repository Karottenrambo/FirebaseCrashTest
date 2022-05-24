using Firebase.Extensions;
using Firebase.Firestore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class SetTestData : MonoBehaviour
{
    private string _characterPath = "character_sheets/testsheet";

    [SerializeField] private TMPro.TMP_InputField _nameField;

    [SerializeField] private TMPro.TMP_InputField _descriptionField;

    [SerializeField] private TMPro.TMP_InputField _attackField;

    [SerializeField] private TMPro.TMP_InputField _defenceField;

    [SerializeField] private Button _submitButton;

    void Start()
    {
        _submitButton.onClick.AddListener(() =>
        {
            FirestoreTestData FirestoreTestData = new FirestoreTestData
            {
                Name = _nameField.text,
                Description = _descriptionField.text,
                Attack = int.Parse(_attackField.text),
                Defense = int.Parse(_defenceField.text)

            };

            //var firebaseapp = Firebase.FirebaseApp.GetInstance("FirebaseEditor");
            //var firestore = FirebaseFirestore.GetInstance(firebaseapp);

            //var firestoreJustCreate = FirebaseFirestore.GetInstance(Firebase.FirebaseApp.Create());

            FirebaseFirestore db = FirebaseFirestore.GetInstance(Firebase.FirebaseApp.Create());
            DocumentReference docRef = db.Collection("character_sheets").Document("testsheet");

            //DocumentReference docRef = firestore.Collection("character_sheets").Document("testsheet");

            //docRef.SetAsync(FirestoreTestData).ContinueWithOnMainThread(task => {
            //    Debug.Log("Added data to the alovelace document in the users collection.");
            //});

            //firestore.Document(_characterPath).SetAsync(FirestoreTestData).ContinueWithOnMainThread(task =>
            //{
            //    Debug.Log("document written");
            //});
            //firestore.Document(_characterPath).GetSnapshotAsync().ContinueWithOnMainThread(task =>
            //{
            //    Assert.IsNull(task.Exception);

            //});
        });
    }
}


