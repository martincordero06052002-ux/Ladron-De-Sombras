using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorInicio : MonoBehaviour
{
    // Esta función la ejecutará el botón
    public void EmpezarPartida()
    {
        // Cargamos la escena del nivel 1. 
        SceneManager.LoadScene("SampleScene");
    }
}