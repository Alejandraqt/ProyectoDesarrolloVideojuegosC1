using UnityEngine;

public class MovimientoTrampa : MonoBehaviour
{
    public Transform modelo;
    public Vector3 direccion = Vector3.right;
    public float distancia = 0.6f;
    public float velocidad = 0.7f;
    public float giro = 360f;

    Vector3 inicio;

    void Start()
    {
        inicio = transform.position;
    }

    void Update()
    {
        transform.position = inicio + direccion * Mathf.PingPong(Time.time * velocidad, distancia);
        modelo.Rotate(0, giro * Time.deltaTime, 0);
    }
}
