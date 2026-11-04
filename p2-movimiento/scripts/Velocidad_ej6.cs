using UnityEngine;
using UnityEngine.InputSystem;

public class Velocidad_ej6 : MonoBehaviour
{
    public float velocidad = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Si pongo esto salen decimales en varios fotogramas hasta llegar al verdadero input.
        // float valorVertical = Input.GetAxis("Vertical");
        // float valorHorizontal = Input.GetAxis("Horizontal");

        // Con GetAxisRaw no pasa: https://docs.unity3d.com/es/530/ScriptReference/Input.GetAxisRaw.html
        float valorVertical = Input.GetAxisRaw("Vertical");
        float valorHorizontal = Input.GetAxisRaw("Horizontal");

        float resultadoVertical = velocidad * valorVertical;
        float resultadoHorizontal = velocidad * valorHorizontal;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha arriba: " + resultadoVertical);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha abajo: " + resultadoVertical);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha izquierda: " + resultadoHorizontal);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha derecha: " + resultadoHorizontal);
        }
    }
}
