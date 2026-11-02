using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public Color colorSeleccionado = Color.white;

    private Renderer rend;
    private Color colorOriginal;

    void Start()
    {
        rend = GetComponent<Renderer>();
        colorOriginal = rend.material.color;
    }

    public void Seleccionado()
    {
        rend.material.color = colorSeleccionado;
    }

    public void Soltado()
    {
        rend.material.color = colorOriginal;
    }
}
