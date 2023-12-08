using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(Rigidbody2D))]
public class missle : MonoBehaviour
{
    public GameObject target;
    float speed = 3f;
    float rotateSpeed = 130f;
    private Rigidbody2D rb;

    void Start()
    {
        target = GameObject.Find("player");
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector2 direction = (Vector2)target.transform.position - rb.position;
            direction.Normalize();
            float rotateAmount = Vector3.Cross(direction, transform.up).z;
            rb.angularVelocity = -rotateAmount * rotateSpeed;
            rb.velocity = transform.up * speed;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}