using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] float speed = 5f; // Movement speed
    [SerializeField] float jumpForce = 10f; // Jump force
    [SerializeField] LayerMask groundLayer; // Layer considered ground for jumping

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move character left/right
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        // Check if grounded
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, groundLayer);

        // Jump input
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void FlipSprite(float direction)
    {
        // Flip sprite direction based on movement
        if (direction > 0 && transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (direction < 0 && transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if colliding with ground
        if (collision.gameObject.layer == groundLayer)
        {
            isGrounded = true;
        }
    }
}