using UnityEngine;

public class ObjetoReferencia : MonoBehaviour
{
    public delegate void Mensaje();
    public static event Mensaje OnCuboSeAproxima;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cubo"))
        {
            OnCuboSeAproxima?.Invoke();
        }
    }
}
