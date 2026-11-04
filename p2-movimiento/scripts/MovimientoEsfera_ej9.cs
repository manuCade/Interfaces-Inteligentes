using UnityEngine;

public class MovimientoEsfera_ej9 : MonoBehaviour
{

    public float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = 0.0f;
        float moveVertical = 0.0f;

        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1;
        }

        Vector3 moveDirection = new(moveHorizontal, moveVertical, 0.0f);

        // moveDirection *= speed; // Ejercicio 9
        moveDirection *= speed * Time.deltaTime; // Ejercicio 10

        transform.Translate(moveDirection);
    }
}
