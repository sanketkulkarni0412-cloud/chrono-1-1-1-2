using UnityEngine;
using UnityEngine.SceneManagement; // Scene badalne ke liye yeh line zaroori hai

public class LevelExit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check karo ki touch karne waala object "Player" hai ya nahi
        if (other.CompareTag("Player"))
        {
            // Agar Player hai, toh "1-2" scene load kar do
            SceneManager.LoadScene("1-2");
        }
    }
}