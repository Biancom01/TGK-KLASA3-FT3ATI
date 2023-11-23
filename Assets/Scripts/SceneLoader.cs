using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadStartScene()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadNextScene()
    {
        int currentindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentindex + 1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
