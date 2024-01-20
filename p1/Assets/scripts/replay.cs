using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
 public void ReplayGame()
    {
        SceneManager.LoadSceneAsync("Level");
    }
public void BacktoMain()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
public void QuitGmae()
    {
        Application.Quit();
    }
}
