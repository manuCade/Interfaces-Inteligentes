using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Humanoide : MonoBehaviour
{
    public delegate void Mensaje();
    public static event Mensaje OnCuboTocaTipo1;
    public static event Mensaje OnCuboTocaTipo2;

    public Transform escudoSeleccionado;
    public Transform escudoObjetivo; // Ej4
    public Transform objetoMirada; // Ej4
    public float radioTeletransporte = 1.5f; // Ej4
    public float velocidad = 3.0f;
    public float distanciaParada = 0.1f;
    public Color colorAlChocar = Color.yellow;

    private Transform destino;

    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;

        if (CompareTag("Tipo1"))
        {
            OnCuboTocaTipo2 += RespuestaTipo1;
            ObjetoReferencia.OnCuboSeAproxima += Teletransportar; // Ej4
        }
        else if (CompareTag("Tipo2"))
        {
            OnCuboTocaTipo1 += RespuestaTipo2;
            ObjetoReferencia.OnCuboSeAproxima += Orientar; // Ej4
        }
    }

    void OnDestroy()
    {
        OnCuboTocaTipo2 -= RespuestaTipo1;
        OnCuboTocaTipo1 -= RespuestaTipo2;
        ObjetoReferencia.OnCuboSeAproxima -= Teletransportar; // Ej4
        ObjetoReferencia.OnCuboSeAproxima -= Orientar; // Ej4
    }

    void Update()
    {
        if (destino == null) return;

        Vector3 direccion = destino.position - transform.position;
        if (direccion.magnitude > distanciaParada)
        {
            transform.Translate(Time.deltaTime * velocidad * direccion.normalized, Space.World);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cubo"))
        {
            if (CompareTag("Tipo1"))
            {
                OnCuboTocaTipo1?.Invoke();
            }
            else if (CompareTag("Tipo2"))
            {
                OnCuboTocaTipo2?.Invoke();
            }
        }
        else if (collision.gameObject.CompareTag("Escudo2"))
        {
            GetComponentInChildren<Renderer>().material.color = colorAlChocar;
        }
    }

    void RespuestaTipo1()
    {
        destino = escudoSeleccionado;
    }

    void RespuestaTipo2()
    {
        float mejorDistancia = Mathf.Infinity;
        foreach (GameObject escudo in GameObject.FindGameObjectsWithTag("Escudo2"))
        {
            float distancia = Vector3.Distance(transform.position, escudo.transform.position);
            if (distancia < mejorDistancia)
            {
                mejorDistancia = distancia;
                destino = escudo.transform;
            }
        }
    }

    // Ej4 
    void Teletransportar()
    {
        destino = null;
        transform.position = new Vector3(
            escudoObjetivo.position.x,
            transform.position.y,
            escudoObjetivo.position.z);
    }

    // Ej4 
    void Orientar()
    {
        Vector3 objetivo = new(
            objetoMirada.position.x,
            transform.position.y,
            objetoMirada.position.z);
        transform.LookAt(objetivo);
    }
}
