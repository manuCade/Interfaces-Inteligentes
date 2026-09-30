using UnityEngine;

public class TeclasEsfera : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.zero;
    public float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed * Time.deltaTime;

        transform.Translate(moveDirection);
    }
}
