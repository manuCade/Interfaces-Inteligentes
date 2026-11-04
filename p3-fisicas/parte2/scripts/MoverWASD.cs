using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class MoverWASD : MonoBehaviour
{

    public float speed = 5.0f;
    Rigidbody rigidbody;
    Vector3 direction;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + speed * Time.fixedDeltaTime * direction);
    }
}
