using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    private float speed = 5.0f;
    private float xBound = 9.0f;

    private int score;

    

    
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Movement();
        KeepInBound();
        ScoreKeeper(0);
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            Destroy(collision.gameObject);
            score += 1;
        }

    }

    private void KeepInBound()
    {
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3 (xBound, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
    }

    public void ScoreKeeper(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }


}

