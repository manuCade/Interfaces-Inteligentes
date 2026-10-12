using UnityEngine;

public class CollideGood : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponentInChildren<Renderer>().material.color = Color.green;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponentInChildren<Renderer>().material.color = Color.white;
    }
}