using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public static MenuManager instance;
   public void GameStart()
    {
        SceneManager.LoadScene("Main");
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
