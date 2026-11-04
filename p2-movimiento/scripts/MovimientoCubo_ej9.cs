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
        float moveHorizontal = 0.0f;
        float moveVertical = 0.0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = 1;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveVertical = 1;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveVertical = -1;
        }

        Vector3 moveDirection = new(moveHorizontal, moveVertical, 0.0f);

        // moveDirection *= speed; // Ejercicio 9
        moveDirection *= speed * Time.deltaTime; // Ejercicio 10

        transform.Translate(moveDirection);
    }
}
