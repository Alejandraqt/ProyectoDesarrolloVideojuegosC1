using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    public string nombre = "Gema";
    public int puntos = 10;
    public AudioClip sonido;
    public GameObject efecto;
    public float velocidadGiro = 90f;

    void Update()
    {
        transform.Rotate(0, velocidadGiro * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider otro)
    {
        if (!otro.CompareTag("Player")) return;

        Puntaje.total += puntos;
        Debug.Log(nombre + " +" + puntos + " puntos | Puntaje total: " + Puntaje.total);
        otro.GetComponent<AudioSource>().PlayOneShot(sonido);
        Instantiate(efecto, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
