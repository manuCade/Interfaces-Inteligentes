using UnityEngine;
using TMPro;

public class ActualizarUI : MonoBehaviour
{
    public TMP_Text texto;

    public void Agarrado()
    {
        texto.text = "¡Bomba agarrada!";
    }

    public void Soltado()
    {
        texto.text = "Bomba no agarrada";
    }
}
