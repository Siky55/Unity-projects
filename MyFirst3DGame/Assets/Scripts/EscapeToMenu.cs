using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // N�zev c�lov� sc�ny (menu)
    public string menuSceneName = "Menu";

    // Metoda pro obsluhu stisku tla��tka ESC
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
           SceneManager.LoadScene(menuSceneName);
        }
    }
}
