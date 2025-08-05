using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName:"GameScene");
    }
}
