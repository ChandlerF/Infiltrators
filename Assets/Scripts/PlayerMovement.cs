 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rb;
    private Vector2 MoveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 MoveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveVelocity = MoveInput.normalized * Speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveVelocity * Time.fixedDeltaTime);   
    }
}
