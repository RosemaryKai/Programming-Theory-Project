using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        ReturnHome();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName:"GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnHome()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneName: "TitleScreen");
            Debug.Log("Escape Clicked");
        }
    }



}
