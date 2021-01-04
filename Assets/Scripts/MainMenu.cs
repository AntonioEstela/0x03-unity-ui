using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayMaze()
    {
        // This will load the game :D
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitMaze()
    {
        // This will quit the game :D
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
