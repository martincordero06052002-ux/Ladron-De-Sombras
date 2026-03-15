using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class RecogerTesoro : MonoBehaviour
{
    // Se activa cuando el jugador pisa el "Trigger" del tesoro
    void OnTriggerEnter2D(Collider2D otro)
    {
        // Comprobamos que el que lo toca es el "Jugador"
        if (otro.gameObject.name == "Jugador")
        {
            Debug.Log("¡Tesoro conseguido!");

            // Cargamos la escena de victoria
            SceneManager.LoadScene("PantallaVictoria");
        }
    }
}