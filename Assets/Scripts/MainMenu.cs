using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void playLevel1()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene(2);
        //SceneManager.GetSceneAt(1);
    }
    public void playLevel2()
    {
        SceneManager.LoadScene(2);
        //SceneManager.LoadScene(2);
        //SceneManager.GetSceneAt(1);
    }
    public void playLevel3()
    {
        SceneManager.LoadScene(3);
        //SceneManager.LoadScene(2);
        //SceneManager.GetSceneAt(1);
    }
    public void quitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();

    }
}
