using UnityEngine;

[RequireComponent(typeof(Renderer))]

public class ChangeColorCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision @object)
    {
        Debug.Log(name + " choca con " + @object.gameObject.name);
        GetComponent<Renderer>().material.color = GetRainbowColor();
    }

    // Completamente innecesario, pero para poner unos colores mejores que un random puro
    Color GetRainbowColor()
    {
        Color[] rainbowColors = new Color[]
        {
            Color.red,
            new(1f, 0.5f, 0f), // Naranja
            Color.yellow,
            Color.green,
            Color.blue,
            new(0.29f, 0f, 0.51f), // Indigo
            new(0.56f, 0f, 1f) // Morado aprox
        };

        return rainbowColors[Random.Range(0, rainbowColors.Length)];
    }
}
