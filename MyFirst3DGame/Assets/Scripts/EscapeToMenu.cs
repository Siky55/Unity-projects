using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Název cílové scény (menu)
    public string menuSceneName = "Menu";

    // Metoda pro obsluhu stisku tlaèítka ESC
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
           SceneManager.LoadScene(menuSceneName);
        }
    }
}
