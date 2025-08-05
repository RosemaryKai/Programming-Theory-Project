using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(sceneName: "GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
