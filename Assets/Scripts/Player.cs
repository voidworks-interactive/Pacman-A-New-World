using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 position;
    public float IShowSpeed;
    public Vector3 inputVector3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("GAME HAS STARTED YEAHHH");
    }

    // Update is called once per frame
    void Update()
    // Update runs once per frame, so it may execute many times per second depending on the computer's performance.
    {
        Debug.Log("UPDATE CALLED");
        // This reads keyboard input and returns a value from -1 to 1: -1 for left or down, 0 for no input, and 1 for right or up.
        inputVector3.x = Input.GetAxis("Horizontal");
        // This works like the X axis, but vertically: up returns 1, down returns -1, and no input returns 0.
        inputVector3.y = Input.GetAxis("Vertical");
        // This built-in Unity function moves the object.
        transform.Translate(inputVector3.x * IShowSpeed, 0f, inputVector3.y * IShowSpeed); // Move the object along the X and Z axes, not the Y axis, to avoid moving it up and down.
    }
}


