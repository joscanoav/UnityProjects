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

    private int posAsteroides1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valorRR = new int[listadoObjetoDanyo.Length];
        InvokeRepeating("CambiarPosicion", 0.0f, 2.0f);
    }

    public void CambiarPosicionAsteroides1()
    {
        posicionXAletoria = Random.Range(limiteI.gameObject.transform.position.x, limiteD.gameObject.transform.position.x);

        listadoAletorio = Random.Range(0, listadoObjetoDanyo.Length);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
