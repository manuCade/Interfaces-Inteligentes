using UnityEngine;

public class AtraccionEsfera : MonoBehaviour
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
        Vector3 direction = sphere.transform.position - transform.position;
        direction.y = 0;
        direction = direction.normalized;
        direction *= speed * Time.deltaTime;

        transform.Translate(direction);
    }
}
