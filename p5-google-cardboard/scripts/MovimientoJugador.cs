using UnityEngine;
using Google.XR.Cardboard;

[RequireComponent(typeof(CharacterController))]

public class MovimientoJugador : MonoBehaviour
{
    public Transform camara;
    public float velocidad = 2.0f;

    private CharacterController controlador;

    void Start()
    {
        controlador = GetComponent<CharacterController>();
    }

    void Update()
    {
        bool avanzando = Api.IsTriggerPressed;
    #if UNITY_EDITOR
        avanzando = avanzando || Input.GetKey(KeyCode.Space);
    #endif

        Vector3 direccion = Vector3.zero;
        if (avanzando)
        {
            direccion = camara.forward;
            direccion.y = 0.0f;
            direccion.Normalize();
        }

        controlador.SimpleMove(direccion * velocidad);
    }
}
