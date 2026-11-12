using JetBrains.Annotations;
using UnityEngine;

public class RigidBodyPlayer : MonoBehaviour
{
    public float IShowSpeed2 = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    public float CallOfDutyJumps = 5f;
    private bool isGrounded = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Gets the Rigidbody component from the object this script is attached to.
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(moveHorizontal, 0, moveVertical).normalized;
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * CallOfDutyJumps, ForceMode.Impulse); // Applies an upward force to the Rigidbody to make it jump.
            isGrounded = false; // Sets isGrounded to false to prevent double jumping.
        }
    }
    void FixedUpdate()
     
    {
        rb.linearVelocity = new Vector3(movement.x * IShowSpeed2, rb.linearVelocity.y, movement.z * IShowSpeed2); // Sets horizontal movement speed while preserving vertical velocity.
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // Checks if the object collided with has the tag "Ground".
        {
            isGrounded = true; // Sets isGrounded to true to allow jumping again.
        }
    }
}


