using UnityEngine;

public class Falling_Star : Falling
{
    new float m_Speed = 3.0f;

    void FixedUpdate()
    {
        MoveDown();
        // INHERITANCE
        DestroyOutOfBounds();
    }

    // Overriden MoveDown() script from Base script.
    // POLYMORPHISM (I think...)
    public override void MoveDown()
    {
        transform.Translate(Vector3.down * m_Speed * Time.deltaTime);
    }
}
