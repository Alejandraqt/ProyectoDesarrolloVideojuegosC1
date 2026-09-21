using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public Cronometro cronometro;
    public string siguienteNivel;
    public float espera = 2f;

    void OnTriggerEnter(Collider otro)
    {
        if (!otro.CompareTag("Player")) return;

        cronometro.Detener();
        Debug.Log("Salió del laberinto en " + cronometro.tiempo.ToString("F1") + " segundos");
        otro.GetComponent<MovimientoJugador>().puedeMoverse = false;

        if (siguienteNivel == "")
        {
            Debug.Log("Juego terminado | Puntaje final: " + Puntaje.total);
        }
        else
        {
            Invoke("CargarNivel", espera);
        }
    }

    void CargarNivel()
    {
        SceneManager.LoadScene(siguienteNivel);
    }
}
