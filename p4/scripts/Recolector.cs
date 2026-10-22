using UnityEngine;

public class Recolector : MonoBehaviour
{
    public delegate void CambioPuntuacion(int puntuacion);
    public static event CambioPuntuacion OnPuntuacionCambia;

    public delegate void RecompensaObtenida(int numero);
    public static event RecompensaObtenida OnRecompensa;

    public int puntosEscudo1 = 5;
    public int puntosEscudo2 = 10;
    public int puntosPorRecompensa = 100;

    private int puntuacion = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Escudo1"))
        {
            Recoger(collision.gameObject, puntosEscudo1);
        }
        else if (collision.gameObject.CompareTag("Escudo2"))
        {
            Recoger(collision.gameObject, puntosEscudo2);
        }
    }

    void Recoger(GameObject escudo, int puntos)
    {
        int recompensasAntes = puntuacion / puntosPorRecompensa;

        puntuacion += puntos;
        Destroy(escudo);
        Debug.Log("+" + puntos + " puntos! Puntuación: " + puntuacion);
        OnPuntuacionCambia?.Invoke(puntuacion);

        int recompensasAhora = puntuacion / puntosPorRecompensa;
        if (recompensasAhora > recompensasAntes)
        {
            OnRecompensa?.Invoke(recompensasAhora);
        }
    }
}
