using UnityEngine;

public class MovimientoTrampa : MonoBehaviour
{
    public Vector3 direccion = Vector3.right;
    public float distancia = 0.9f;
    public float velocidad = 0.5f;

    Vector3 inicio;

    void Start()
    {
        inicio = transform.position;
    }

    void Update()
    {
        transform.position = inicio + direccion * Mathf.PingPong(Time.time * velocidad, distancia);
    }
}
