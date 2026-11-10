using UnityEngine;

public class RigidBodyPlayer : MonoBehaviour
{
    public float IShowSpeed2 = 5f;
    private Rigidbody rb;
    private Vector3 movement;
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
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * IShowSpeed2 * Time.fixedDeltaTime); // Moves the Rigidbody based on the input and speed.
    }
}

