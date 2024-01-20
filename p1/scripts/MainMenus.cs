using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenus : MonoBehaviour
{
    public void playLevel()
    {
        SceneManager.LoadSceneAsync("Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
