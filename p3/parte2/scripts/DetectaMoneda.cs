using UnityEngine;

public class DetectaMoneda : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(name + " detecta a " + other.gameObject.name);
    }
}
