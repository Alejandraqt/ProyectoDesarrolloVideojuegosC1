using UnityEngine;

public class CamaraSigue : MonoBehaviour
{
    public Transform jugador;
    public Vector3 offset = new Vector3(0, 7, -4.5f);
    public float suavizado = 5f;

    void LateUpdate()
    {
        Vector3 destino = jugador.position + offset;
        transform.position = Vector3.Lerp(transform.position, destino, suavizado * Time.deltaTime);
    }
}
