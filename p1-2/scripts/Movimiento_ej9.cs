using UnityEngine;

public class Movimiento_ej9 : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        // moveDirection *= speed; // Ejercicio 9
        moveDirection *= speed * Time.deltaTime; // Ejercicio 10

        transform.Translate(moveDirection);
    }
}
