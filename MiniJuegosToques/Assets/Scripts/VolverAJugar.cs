using UnityEngine;
using UnityEngine.SceneManagement;
public class VolverAJugar : MonoBehaviour
{
    public void Reiniciar() { 
        SceneManager.LoadScene("Juego");
    }
}
