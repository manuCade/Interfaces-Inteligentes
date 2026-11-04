using UnityEngine;

public class Cilindro : MonoBehaviour
{
    public delegate void MensajeColision();
    public event MensajeColision OnCuboColisiona;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cubo"))
        {
            OnCuboColisiona?.Invoke();
        }
    }
}
