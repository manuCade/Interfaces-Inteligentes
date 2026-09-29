using UnityEngine;

public class ConexionEsferaConObjetos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Podemos conseguir otros objetos usando tags (tienen que tenerlo de antemano)
        GameObject cuboBasico = GameObject.FindWithTag("cubo_basico");
        GameObject cilindroBasico = GameObject.FindWithTag("cilindro_basico");
        Vector3 vectorCubo = cuboBasico.transform.position;
        Vector3 vectorCilindro = cilindroBasico.transform.position;
        float distanceBetweenCuboAndCilindro = Vector3.Distance(vectorCubo, vectorCilindro);
        Debug.Log($"La distancia entre el cubo y el cilindro es de {distanceBetweenCuboAndCilindro}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
