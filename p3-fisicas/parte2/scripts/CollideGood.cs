using UnityEngine;

public class CollideGood : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Renderer>().material.color = Color.green;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Renderer>().material.color = Color.white;
    }
}