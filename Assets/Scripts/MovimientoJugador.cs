using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    public float fuerza = 5f;
    public bool puedeMoverse = true;
    public AudioClip sonidoChoque;

    Rigidbody rb;
    AudioSource fuenteAudio;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fuenteAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (transform.position.y < -10)
        {
            Puntaje.total = 0;
            SceneManager.LoadScene("Nivel1");
        }
    }

    void FixedUpdate()
    {
        if (!puedeMoverse) return;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(h, 0, v) * fuerza);
    }

    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("Pared") && colision.relativeVelocity.magnitude > 0.5f)
        {
            fuenteAudio.PlayOneShot(sonidoChoque);
        }
    }
}
