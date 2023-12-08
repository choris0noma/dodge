using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _player;
    public float force;

    void Awake()
    {
        force = 8;
    }
    private void FixedUpdate() 
    { 
        Vector2 acceleration = Input.acceleration;
        _player.velocity = new Vector2(acceleration.x * force, acceleration.y * force);
    }
}
