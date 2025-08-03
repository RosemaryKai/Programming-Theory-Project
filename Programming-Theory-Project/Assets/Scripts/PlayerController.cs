using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
