using UnityEngine;

public class Falling_Star : Falling
{
    new float m_Speed = 5.0f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        MoveDown();
    }

    // Overriden MoveDown() script from Base script.
    public override void MoveDown()
    {
        transform.Translate(Vector3.down * m_Speed * Time.deltaTime);
    }
}
