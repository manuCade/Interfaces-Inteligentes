using System;
using UnityEngine;

public class SensorMirada : MonoBehaviour
{
    public static event Action<GameObject> OnMiradaSeleccionada;

    public float distanciaMaxima = 6.0f;
    public float tiempoMirada = 1.5f;

    private GameObject objetoActual;
    private float temporizador;
    private int capaInteractiva;

    void Start()
    {
        capaInteractiva = LayerMask.NameToLayer("Interactive");
    }

    void Update()
    {
        GameObject objetivo = null;

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit impacto, distanciaMaxima))
        {
            if (impacto.collider.gameObject.layer == capaInteractiva) 
            {
                objetivo = impacto.collider.gameObject;
            }
        }

        if (objetivo != null && objetivo == objetoActual)
        {
            temporizador += Time.deltaTime;
            if (temporizador >= tiempoMirada)
            {
                OnMiradaSeleccionada?.Invoke(objetivo);
                temporizador = 0.0f;
            }
        }
        else
        {
            objetoActual = objetivo;
            temporizador = 0.0f;
        }
    }
}
