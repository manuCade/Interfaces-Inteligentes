using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class MoverWASD : MonoBehaviour
{

    public float speed = 5.0f;
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = new(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rigidbody.MovePosition(rigidbody.position + speed * Time.fixedDeltaTime * direction);
    }
}
