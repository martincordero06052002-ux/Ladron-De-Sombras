using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public void ReiniciarJuego()
    {
        Debug.Log("Volviendo al nivel principal...");

        SceneManager.LoadScene("SampleScene");
    }
}