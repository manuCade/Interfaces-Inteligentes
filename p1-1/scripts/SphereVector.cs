using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SphereVector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject sphere1 = GameObject.FindWithTag("esfera_basica");
        Vector3 posicion = sphere1.transform.position;
        GetComponent<TMP_Text>().text = "Posición de la esfera: " + posicion.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
