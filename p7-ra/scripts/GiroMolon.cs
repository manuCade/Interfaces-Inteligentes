using UnityEngine;

public class GiroMolon : MonoBehaviour
{
    private float velocidad = 40.0f;
    private float amplitud = 0.02f;
    private float frecuencia = 0.5f;

    private Vector3 posicionInicial;
    private float tiempo;

    void Awake()
    {
        posicionInicial = transform.localPosition;
        enabled = false;
    }

    // OnTargetFound
    public void IniciarRotacion()
    {
        tiempo = 0.0f;
        transform.localPosition = posicionInicial;
        enabled = true;
    }

    // OnTargetLost
    public void DetenerRotacion()
    {
        enabled = false;
    }

    void Update()
    {
        transform.Rotate(0.0f, velocidad * Time.deltaTime, 0.0f, Space.Self);

        tiempo += Time.deltaTime;

        float desplazamiento = Mathf.Sin(tiempo * 2.0f * Mathf.PI * frecuencia) * amplitud;
        transform.localPosition = posicionInicial + (Vector3.up * desplazamiento);
    }
}
