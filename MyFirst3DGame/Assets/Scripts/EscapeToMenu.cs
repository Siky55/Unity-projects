using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenuAndCenterMouse : MonoBehaviour
{
    public string menuSceneName = "MenuScene"; // N�zev sc�ny "Menu"

    void Update()
    {
        // Pokud bylo stisknuto tla��tko ESC/X
        if (Input.GetKeyDown(KeyCode.X)||Input.GetKeyDown(KeyCode.X))
        {
            // Na�te sc�nu "Menu"
            SceneManager.LoadScene(menuSceneName);

            // Nastav� kurzor my�i do st�edu obrazovky
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
