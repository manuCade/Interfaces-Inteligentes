using System;
using UnityEngine;

public class PuntoReunion : MonoBehaviour
{
    public static event Action<Transform> OnPuntoReunionSeleccionado;
    public Transform jugador;

    void OnEnable()
    { 
        SensorMirada.OnMiradaSeleccionada += AlMirarObjeto; 
    }

    void OnDisable() 
    { 
        SensorMirada.OnMiradaSeleccionada -= AlMirarObjeto;
    }

    void AlMirarObjeto(GameObject objetoMirado)
    {
        if (objetoMirado.transform.IsChildOf(transform))
        {
            OnPuntoReunionSeleccionado?.Invoke(jugador);
        }
    }
}
