using JetBrains.Annotations;
using UnityEngine;

public class Movimiento_ej8 : MonoBehaviour
{

    public Vector3 moveDirection = new(1, 1, 0);
    public float speed = 1.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // transform.position = new(transform.position.x, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        float x = moveDirection.x * speed * Time.deltaTime;
        float y = moveDirection.y * speed * Time.deltaTime;
        float z = moveDirection.z * speed * Time.deltaTime;

        transform.Translate(x, y, z);
        // transform.Translate(x, y, z, Self.World);
    }
}
