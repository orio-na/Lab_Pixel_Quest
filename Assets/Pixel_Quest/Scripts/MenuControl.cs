using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    public string nextLevel;
    public void LoadLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}