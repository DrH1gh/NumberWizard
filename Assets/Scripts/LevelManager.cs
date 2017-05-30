using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("Level loaded " + name);
        
        SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Debug.Log("Quiting... Works only if you make a build.");
        Application.Quit();
    }
}
