using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenuAndCenterMouse : MonoBehaviour
{
    public string menuSceneName = "MenuScene"; // Název scény "Menu"

    void Update()
    {
        // Pokud bylo stisknuto tlaèítko ESC/X
        if (Input.GetKeyDown(KeyCode.X)||Input.GetKeyDown(KeyCode.X))
        {
            // Naète scénu "Menu"
            SceneManager.LoadScene(menuSceneName);

            // Nastaví kurzor myši do støedu obrazovky
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
