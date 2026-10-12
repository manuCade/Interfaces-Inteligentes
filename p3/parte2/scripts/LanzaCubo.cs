using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class LanzaCubo : MonoBehaviour
{
    public Vector3 force = Vector3.forward;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
        }
    }
}
