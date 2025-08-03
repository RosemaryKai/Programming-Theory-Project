using UnityEngine;

public class Falling : MonoBehaviour
{
    // Speeds for derived scripts
    private float speed = 5.0f;
    protected float m_Speed
    {
        get { return speed; }
        set
        {
            speed = Mathf.Clamp(value, 0f, 10f);
        }
    }

    // Creates a method that is forced to be overriden in derived scripts
    public virtual void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
