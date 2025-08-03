using UnityEngine;

public class Falling : MonoBehaviour
{

    private float speed = 5.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
