using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Vector3 firstVector = new(0.0f, 1.0f, 0.0f);
    public Vector3 secondVector = new(1.0f, 0.0f, 0.0f);

    public float firstMagnitude;
    public float secondMagnitude;
    public float angleBetween;
    public float distanceBetween;
    public string higherAltitudeMessage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        firstMagnitude = firstVector.magnitude;
        secondMagnitude = secondVector.magnitude;
        angleBetween = Vector3.Angle(firstVector, secondVector);
        distanceBetween = Vector3.Distance(firstVector, secondVector);

        if (firstVector.y > secondVector.y)
        {
            higherAltitudeMessage = "El primer vector está a mayor altura.";
        }
        else if (secondVector.y > firstVector.y)
        {
            higherAltitudeMessage = "El segundo vector está a mayor altura.";
        }
        else
        {
            higherAltitudeMessage = "Ambos vectores están a la misma altura.";
        }

        Debug.Log($"Magnitud del primer vector: {firstMagnitude}");
        Debug.Log($"Magnitud del segundo vector: {secondMagnitude}");
        Debug.Log($"Ángulo entre vectores: {angleBetween} grados");
        Debug.Log($"Distancia entre vectores: {distanceBetween}");
        Debug.Log(higherAltitudeMessage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
