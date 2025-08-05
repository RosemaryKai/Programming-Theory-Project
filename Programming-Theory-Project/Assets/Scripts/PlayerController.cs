using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;

    public float speed = 5.0f;
    public float jumpForce = 2.0f;

    

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Movement();
        Dash();
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
        }

    }

    private void Dash()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerRb.AddForce(Vector3.zero, ForceMode.Impulse);
        }
    }


}
