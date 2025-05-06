using UnityEngine;

public class ControladorObjetosDayno : MonoBehaviour
{
    [SerializeField]
    private GameObject limiteI;
    [SerializeField]
    private GameObject limiteD;
    [SerializeField]
    private GameObject [] listadoObjetoDanyo;

    private int[] valorRR;

    private int listadoAletorio;

    private float posicionXAletoria;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valorRR = new int[listadoObjetoDanyo.Length];
        InvokeRepeating("CambiarPosicionAsteroides1", 0.0f, 2.0f);
    }

    public void CambiarPosicionAsteroides1()
    {
        posicionXAletoria = Random.Range(limiteI.gameObject.transform.position.x, limiteD.gameObject.transform.position.x);

        listadoAletorio = Random.Range(0, listadoObjetoDanyo.Length);

        listadoObjetoDanyo[listadoAletorio].gameObject.transform.GetChild(valorRR[listadoAletorio]).gameObject.transform.position = new Vector2(posicionXAletoria,limiteI.gameObject.transform.position.y);
        listadoObjetoDanyo[listadoAletorio].gameObject.transform.GetChild(valorRR[listadoAletorio]).gameObject.GetComponent<Rigidbody2D>().gravityScale=0.2f;

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
