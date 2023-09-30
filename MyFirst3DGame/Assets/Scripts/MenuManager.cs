using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //prechazeni mezi scenami

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void START()
    {
        SceneManager.LoadScene("Hra");
    }

    public void EXIT()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Quality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }

    public void Fullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }
}
