using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public int playerLives;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName:"GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
