using UnityEngine;
using TMPro;

public class Player2D : MonoBehaviour

    

{

    [SerializeField]
    private float velocidad;

    private int puntuacion;
    [SerializeField]
    private GameObject puntacionUI;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //puntacionUI = (GameObject)GameObject.FindGameObjectWithTag("PuntuacionUI");
        //if (puntacionUI != null)
        //{
        //    Debug.Log("se ha encontrado el objeto con la etiqueta PuntuacionUI");
        //    puntacionUI.SetActive(false);
        //}
        //else
        //{
        //    Debug.Log("No existe");
        //}
        //puntacionUI.SetActive(false);
        this.puntuacion = 0;    


    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime, 0.0f,0.0f);







        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    Debug.Log("D key pressed");
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Debug.Log("A key pressed");
        //}


        //Input.GetMouseButtonDown(1);

        
        //Debug.Log(Input.GetAxis("Horizontal"));

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Balon") { 
            puntuacion = puntuacion + 1;

            puntacionUI.gameObject.GetComponent<TMP_Text>().text = puntuacion.ToString();


            Debug.Log("Puntuacion: " + puntuacion);
        }
    }
}
