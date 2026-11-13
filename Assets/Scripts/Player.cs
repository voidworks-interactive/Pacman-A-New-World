using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 position;
    public float IShowSpeed;
    public Vector3 inputVector3;
    void Start()
    {
        Debug.Log("GAME HAS STARTED YEAHHH");
    }

    void Update()
    {
        Debug.Log("UPDATE CALLED");
        inputVector3.x = Input.GetAxis("Horizontal");
        inputVector3.y = Input.GetAxis("Vertical");
        transform.Translate(inputVector3.x * IShowSpeed, 0f, inputVector3.y * IShowSpeed);
    }
}


