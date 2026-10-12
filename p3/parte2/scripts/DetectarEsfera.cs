using UnityEngine;
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Renderer))]

public class DetectarEsfera : MonoBehaviour
{
    public Collider sphereCollider;
    public Material newMaterial;

    bool isColliding = false;

    void Update()
    {
        if (GetComponent<Collider>().bounds.Intersects(sphereCollider.bounds) && !isColliding)
        {
            GetComponent<Renderer>().material = newMaterial;
            isColliding = true;
        }

        else
        {
            isColliding = false;
        }
    }
}
