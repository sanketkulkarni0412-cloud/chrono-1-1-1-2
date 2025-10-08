using UnityEngine;
using Firebase.Auth;

public class FirebaseTest : MonoBehaviour
{
    // Start mein S capital
    void Start()
    {
        // Debug mein D capital
        Debug.Log("Firebase Test Script Started...");
        FirebaseAuth.DefaultInstance.SignInAnonymouslyAsync().ContinueWith(task => {
            if (task.IsCanceled || task.IsFaulted)
            {
                // Debug mein D capital
                Debug.LogError("Login Failed: " + task.Exception);
                return;
            }
            // FirebaseUser mein U capital
            FirebaseUser user = task.Result.User;
            // Debug mein D capital
            Debug.Log("LOGIN SUCCESSFUL! User ID: " + user.UserId);
        });
    }
}