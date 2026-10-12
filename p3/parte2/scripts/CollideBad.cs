using UnityEngine;

public class CollideBad : MonoBehaviour
{
    public float damage = 0.0f;
    public float damageGainRate = 0.01f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponentInChildren<Renderer>().material.color = Color.red;
    }

    void OnTriggerStay(Collider other)
    {
        damage += damageGainRate * Time.fixedDeltaTime;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponentInChildren<Renderer>().material.color = Color.white;
    }
}
