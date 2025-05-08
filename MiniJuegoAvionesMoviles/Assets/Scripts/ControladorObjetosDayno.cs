using System.Collections;
using UnityEngine;

public class ControladorObjetosDayno : MonoBehaviour
{
    [SerializeField]
    private GameObject limiteI;
    [SerializeField]
    private GameObject limiteD;
    [SerializeField]
    private GameObject[] listadoObjetoDanyo;

    private int[] valorRR;

    private int listadoAletorio;

    private float posicionXAletoria;

    private float velocidadPosicionamiento;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        velocidadPosicionamiento = 2.0f;
        valorRR = new int[listadoObjetoDanyo.Length];
        //InvokeRepeating("CambiarPosicionAsteroides1", 0.0f, 2.0f);
        StartCoroutine(CambioDePosicion());
    }

    IEnumerator CambioDePosicion()
    {
        while (true)
        {
            yield return new WaitForSeconds(velocidadPosicionamiento);
            velocidadPosicionamiento = velocidadPosicionamiento - 0.01f;
            if (velocidadPosicionamiento <= 0.5f)
            {
                velocidadPosicionamiento = 0.5f;
            }
            CambiarPosicionAsteroides1();
        }
    }

    public void CambiarPosicionAsteroides1()
    {

        posicionXAletoria = Random.Range(limiteI.gameObject.transform.position.x, limiteD.gameObject.transform.position.x);

        listadoAletorio = Random.Range(0, listadoObjetoDanyo.Length);

        listadoObjetoDanyo[listadoAletorio].gameObject.transform.GetChild(valorRR[listadoAletorio]).gameObject.transform.position = new Vector2(posicionXAletoria, limiteI.gameObject.transform.position.y);
        listadoObjetoDanyo[listadoAletorio].gameObject.transform.GetChild(valorRR[listadoAletorio]).gameObject.GetComponent<Rigidbody2D>().linearVelocity=Vector2.zero;
        listadoObjetoDanyo[listadoAletorio].gameObject.transform.GetChild(valorRR[listadoAletorio]).gameObject.GetComponent<Rigidbody2D>().gravityScale = 0.2f;


        valorRR[listadoAletorio]++;

        if (valorRR[listadoAletorio] >= listadoObjetoDanyo[listadoAletorio].gameObject.transform.childCount)
        {
            valorRR[listadoAletorio] = 0;
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
