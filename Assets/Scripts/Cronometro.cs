using UnityEngine;

public class Cronometro : MonoBehaviour
{
    public float tiempo;
    public bool corriendo;

    void Update()
    {
        if (corriendo)
        {
            tiempo += Time.deltaTime;
        }
    }

    public void Iniciar()
    {
        corriendo = true;
    }

    public void Detener()
    {
        corriendo = false;
    }
}
