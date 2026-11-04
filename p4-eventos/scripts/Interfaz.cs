using UnityEngine;
using TMPro;

public class Interfaz : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;
    public TextMeshProUGUI textoRecompensa;
    public float segundosRecompensa = 3.0f;
    public string[] recompensas = { "Espada de madera", "Espada de acero forjada", "Excalibur" };

    void Start()
    {
        Recolector.OnPuntuacionCambia += ActualizarPuntuacion;
        Recolector.OnRecompensa += MostrarRecompensa;

        textoPuntuacion.text = "Puntuación: 0";
        textoRecompensa.text = "";
    }

    void OnDestroy()
    {
        Recolector.OnPuntuacionCambia -= ActualizarPuntuacion;
        Recolector.OnRecompensa -= MostrarRecompensa;
    }

    void ActualizarPuntuacion(int puntuacion)
    {
        textoPuntuacion.text = "Puntuación: " + puntuacion;
    }

    void MostrarRecompensa(int numero)
    {
        string nombre = recompensas[(numero - 1) % recompensas.Length];
        textoRecompensa.text = "¡Has conseguido " + nombre + "!";

        CancelInvoke(nameof(OcultarRecompensa));
        Invoke(nameof(OcultarRecompensa), segundosRecompensa);
    }

    void OcultarRecompensa()
    {
        textoRecompensa.text = "";
    }
}
