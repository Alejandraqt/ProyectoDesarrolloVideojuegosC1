using UnityEngine;
using UnityEngine.SceneManagement;

public class Trampa : MonoBehaviour
{
    public GameObject efecto;
    public AudioClip sonido;
    public float espera = 1.5f;

    void OnTriggerEnter(Collider otro)
    {
        if (!otro.CompareTag("Player")) return;

        otro.GetComponent<MovimientoJugador>().puedeMoverse = false;
        otro.GetComponent<Rigidbody>().isKinematic = true;
        otro.GetComponent<MeshRenderer>().enabled = false;
        otro.GetComponent<AudioSource>().PlayOneShot(sonido);
        Instantiate(efecto, otro.transform.position, Quaternion.identity);
        Debug.Log("Caíste en una trampa, el juego vuelve a comenzar");
        Invoke("Reiniciar", espera);
    }

    void Reiniciar()
    {
        Puntaje.total = 0;
        SceneManager.LoadScene("Nivel1");
    }
}
