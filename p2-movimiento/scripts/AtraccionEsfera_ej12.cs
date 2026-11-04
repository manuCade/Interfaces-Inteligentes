using UnityEngine;

public class AtraccionEsfera_ej12 : MonoBehaviour
{
    public float speed = 1.0f;
    private GameObject sphere;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sphere = GameObject.Find("EsferaAtrae");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new(sphere.transform.position.x, transform.position.y, sphere.transform.position.z);
        transform.LookAt(targetPosition);
    
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        // Alternativamente
        // transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
}
