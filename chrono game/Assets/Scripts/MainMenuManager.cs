using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // This function will be called by our button
    public void StartGame()
    {
        // Loads the scene named "1-1"
        SceneManager.LoadScene("1-1");
    }
}