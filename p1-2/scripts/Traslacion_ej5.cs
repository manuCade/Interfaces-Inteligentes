using UnityEngine;

public class Traslacion_ej5 : MonoBehaviour
{
    public GameObject objeto_marcador;
    private Vector3 desplazamiento;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        desplazamiento = objeto_marcador.transform.position;
        if (Input.GetAxis("Jump") > 0)
        {
            // Si se refiere a simplemente ponerlo en el mismo sitio que el objeto marcador
            transform.position = desplazamiento;
            // Si se refiere a que sea un desplazamiento real
            // transform.Translate(desplazamiento);
        }
    }
}
