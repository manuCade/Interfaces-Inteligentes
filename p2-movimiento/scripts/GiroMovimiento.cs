using UnityEngine;

public class GiroMovimiento : MonoBehaviour
{

    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalRotation = Input.GetAxis("Horizontal") * 100.0f * Time.deltaTime;

        transform.Rotate(0, horizontalRotation, 0);
        
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        Debug.DrawRay(transform.position, transform.forward * 5f, Color.red);
    }
}
