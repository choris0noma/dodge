using UnityEngine;

public class MovementRockets : MonoBehaviour
{
    public Vector2 direction;
    float speed = 0.05f;

    void FixedUpdate() 
    {
        transform.Translate(direction.normalized* speed, Space.World);
    }
}
