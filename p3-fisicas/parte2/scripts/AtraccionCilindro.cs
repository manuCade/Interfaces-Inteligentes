using UnityEngine;

public class AtraccionCilindro : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject gameObjectToBeAttracted;

    void Update()
    {
        Vector3 targetPosition = new(
            gameObjectToBeAttracted.transform.position.x, 
            transform.position.y, 
            gameObjectToBeAttracted.transform.position.z
        );
        transform.LookAt(targetPosition);
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
}
