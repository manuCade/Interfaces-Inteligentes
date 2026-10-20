using UnityEngine;

public class Esfera : MonoBehaviour
{
    public Cilindro cilindro;
    public Transform objetivoTipo1;
    public float velocidad = 3.0f;
    public float distanciaParada = 1.0f;

    private Transform destino;

    void Start()
    {
        if (CompareTag("Tipo1"))
        {
            cilindro.OnCuboColisiona += RespuestaTipo1;
        }
        else if (CompareTag("Tipo2"))
        {
            cilindro.OnCuboColisiona += RespuestaTipo2;
        }
    }

    void Update()
    {
        Vector3 direccion = destino.position - transform.position;
        if (direccion.magnitude > distanciaParada)
        {
            transform.Translate(Time.deltaTime * velocidad * direccion.normalized, Space.World);
        }
    }

    void RespuestaTipo1()
    {
        destino = objetivoTipo1;
    }

    void RespuestaTipo2()
    {
        destino = cilindro.transform;
    }
}
