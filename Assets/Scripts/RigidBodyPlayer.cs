using JetBrains.Annotations;
using UnityEngine;

public class RigidBodyPlayer : MonoBehaviour
{
    public float IShowSpeed2 = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    public float CallOfDutyJumps = 5f;
    private bool isGrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(moveHorizontal, 0, moveVertical).normalized;
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * CallOfDutyJumps, ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void FixedUpdate()
     
    {
        rb.linearVelocity = new Vector3(movement.x * IShowSpeed2, rb.linearVelocity.y, movement.z * IShowSpeed2);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}


