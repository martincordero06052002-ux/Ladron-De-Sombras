using UnityEngine;

public class PatrullaGuardia : MonoBehaviour
{
    // Las "casillas" donde pondremos nuestros Puntos A y B
    public Transform puntoA;
    public Transform puntoB;

    // A qué velocidad camina el guardia
    public float velocidad = 2f;

    // Esta variable recuerda hacia dónde estamos caminando ahora mismo
    private Transform objetivoActual;

    void Start()
    {
        // Al empezar el juego, le decimos que vaya primero al Punto A
        objetivoActual = puntoA;
    }
    
    void Update()
    {
        // 1. MOVER AL GUARDIA
        // MoveTowards es una función mágica que mueve algo desde su posición actual hacia un objetivo
        transform.position = Vector2.MoveTowards(transform.position, objetivoActual.position, velocidad * Time.deltaTime);

        // 2. COMPROBAR SI HEMOS LLEGADO
        // Medimos la distancia entre el guardia y el objetivo. Si es casi cero (0.1)...
        if (Vector2.Distance(transform.position, objetivoActual.position) < 0.1f)
        {
            // Cambiamos de objetivo. Si estábamos yendo al A, ahora vamos al B.
            if (objetivoActual == puntoA)
            {
                objetivoActual = puntoB;
            }
            else // Si no... estábamos yendo al B, así que volvemos al A.
            {
                objetivoActual = puntoA;
            }
        }
    }
}