using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private int puntuacion;
    private int record;

    [SerializeField]
    private GameObject PuntuacionUI;

    [SerializeField]
    private GameObject RecordUI;

    [SerializeField]
    private GameObject panelDerrota;


    public void Reiniciar() {
        SceneManager.LoadScene("Juego");
    }

    public void ActualizarPuntuacion(int incremento)
    {
        puntuacion = puntuacion + incremento;
        ActualizarPuntuacionUI(puntuacion);

        // Actualizar el record
        record = PlayerPrefs.GetInt("Record");

        if (puntuacion > record)
        {
            PlayerPrefs.SetInt("Record", puntuacion);
            record = PlayerPrefs.GetInt("Record");
            ActualizarRecordUI(puntuacion);
        }
    }

    public void ActualizarPuntuacionUI (int puntos)
    {
        PuntuacionUI.gameObject.GetComponent<TMP_Text>().text = puntos.ToString();
    }

    public void ActualizarRecordUI(int puntosRecord)
    {
        RecordUI.gameObject.GetComponent<TMP_Text>().text = puntosRecord.ToString();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
        puntuacion = 0;
        record = 0;
        ActualizarPuntuacionUI(puntuacion);
        ActualizarRecordUI(record);

        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.DeleteKey("Record");

        if (PlayerPrefs.HasKey("Record"))
        {
            record = PlayerPrefs.GetInt("Record");
            ActualizarRecordUI(record);
        }
        else
        {
            PlayerPrefs.SetInt("Record", 0);
            record = PlayerPrefs.GetInt("Record");
            ActualizarRecordUI(record);
        }

    }

    public void MostrarPanelDerrota()
    {
        panelDerrota.gameObject.SetActive(true);
        Time.timeScale = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
