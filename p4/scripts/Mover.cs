using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Mover : MonoBehaviour
{
    public float velocidad = 5.0f;
    Rigidbody rigidbody;
    Vector3 direccion;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direccion = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + velocidad * Time.fixedDeltaTime * direccion);
        if (direccion != Vector3.zero) 
        {
            rigidbody.MoveRotation(Quaternion.LookRotation(direccion));
        }
    }
}
