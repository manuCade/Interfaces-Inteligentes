using UnityEngine;

public class Recolectable : MonoBehaviour
{
    public float velocidad = 3.0f;
    public float distanciaParada = 2.0f;

    private bool recolectado;
    private Transform destino;

    void OnEnable()
    {
        SensorMirada.OnMiradaSeleccionada += AlMirarObjeto;
        PuntoReunion.OnPuntoReunionSeleccionado += AlMirarPuntoReunion;
    }

    void OnDisable()
    {
        SensorMirada.OnMiradaSeleccionada -= AlMirarObjeto;
        PuntoReunion.OnPuntoReunionSeleccionado -= AlMirarPuntoReunion;
    }

    void AlMirarObjeto(GameObject objetoMirado)
    {
        // Solo reaccionamos si el objeto mirado somos nosotros
        if (recolectado || !objetoMirado.transform.IsChildOf(transform)) return;

        recolectado = true;
        MostrarObjeto(false);
        Debug.Log(name + " recolectado");
    }

    void AlMirarPuntoReunion(Transform jugador)
    {
        if (!recolectado) return;

        recolectado = false;
        destino = jugador;
        MostrarObjeto(true);
    }

    void Update()
    {
        if (destino == null) return;

        if (Vector3.Distance(transform.position, destino.position) > distanciaParada) 
        {
            transform.position = Vector3.MoveTowards(transform.position, destino.position, velocidad * Time.deltaTime);
        }
        else 
        {
            destino = null;
        }
    }

    void MostrarObjeto(bool visible)
    {
        foreach (Renderer renderer in GetComponentsInChildren<Renderer>()) renderer.enabled = visible;
        foreach (Collider colider in GetComponentsInChildren<Collider>()) colider.enabled = visible;
    }
}
