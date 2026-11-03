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
    // el update literamente lo que hace es actualizarse frame por frame, es decir, que se ejecuta muchisimas veces por segundo, dependiendo de la potencia del ordenador
    {
        Debug.Log("UPDATE CALLED");
        // eso lo que hace literal es detectar la entrada del teclado, y dependiendo de la tecla que pulses, te devuelve un valor entre -1 y 1, siendo -1 cuando pulsas la tecla izquierda o abajo, 0 cuando no pulsas nada y 1 cuando pulsas la tecla derecha o arriba
        inputVector3.x = Input.GetAxis("Horizontal");
        // hace lo mismo que el x pero en el otro eye asi que verticalmente, es decir, que si pulsas la tecla de arriba te devuelve 1, si pulsas la tecla de abajo te devuelve -1 y si no pulsas nada te devuelve 0
        inputVector3.y = Input.GetAxis("Vertical");
        // lo que hace es un evento o una funcion que viene integrada en unity q hace el objeto se mueva
        transform.Translate(inputVector3.x * IShowSpeed, 0f, inputVector3.y * IShowSpeed); // lo de adentro hace que el objeto se mueva en el eje x y en el eje z, pero no en el eje y, ya que si lo hiciera se moveria hacia arriba y hacia abajo, y eso no es lo que queremos
    }
}


