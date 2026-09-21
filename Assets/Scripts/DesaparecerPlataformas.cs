using UnityEngine;

public class DesaparecerPlataformas : MonoBehaviour
{
    public GameObject plataformas;
    public Cronometro cronometro;
    public AudioClip sonido;

    void OnTriggerEnter(Collider otro)
    {
        if (!otro.CompareTag("Player")) return;

        otro.GetComponent<AudioSource>().PlayOneShot(sonido);
        plataformas.SetActive(false);
        cronometro.Iniciar();
        gameObject.SetActive(false);
    }
}
