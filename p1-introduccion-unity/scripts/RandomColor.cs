using UnityEngine;

public class RandomColor : MonoBehaviour
{
    // Ponemos todas las variables fuera de Start() y Update()
    // En público para poder manipularlo desde el inspector
    public int colorDurationInFrames = 120;
    // El resto en privado
    private float[] colorChannels = new float[3];
    private Renderer renderer;
    private int frameCounter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Conseguimos el componente del renderizador (para poder aplicar el color)
        renderer = GetComponent<Renderer>();

        for (int i = 0; i < colorChannels.Length; ++i)
        {
            // Asignamos a cada canal de color un color aleatorio usando Random.Range()
            colorChannels[i] = Random.Range(0.0f, 1.0f);
        }

        // Existe el objeto Color que toma 4 parámetros (los tres canales y la transparencia)
        // No hace falta poner new Color porque el Color de la izquierda ya indica el tipo de objeto.
        Color newColor = new(colorChannels[0], colorChannels[1], colorChannels[2], 1.0f);
        renderer.material.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {
        ++frameCounter;
        if (frameCounter >= colorDurationInFrames)
        {
            // Randomizamos un canal aleatoriamente
            int randomColorChannel = Random.Range(0, colorChannels.Length);
            colorChannels[randomColorChannel] = Random.Range(0.0f, 1.0f);
            // Y aplicamos el color nuevo
            Color newColor = new(colorChannels[0], colorChannels[1], colorChannels[2], 1.0f);
            renderer.material.color = newColor;

            frameCounter = 0;
        }
    }
}
