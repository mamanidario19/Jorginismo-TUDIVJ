using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class pieza : MonoBehaviour
{
    private Vector3 PosicionCorrecta;
    public bool Encajada;
    public bool Seleccionada;

    void Start()
    {
        PosicionCorrecta = transform.position;
        //las piezas se posicionan de manera aleatoria en ese rango indicado
        transform.position = new Vector3(Random.Range(5f, 11f), Random.Range(2.5f, -7));
    }
    
    void Update()
    {
        //si la pieza se coloca esa distancia de posicion, en el momento
        //que deje de estar seloccionada, la posiciona  en su pos correcta
        if (Vector3.Distance(transform.position, PosicionCorrecta) < 0.5f)
        {
            if (!Seleccionada)
            {
                if (Encajada == false)
                {
                    transform.position = PosicionCorrecta;
                    Encajada = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<juego>().PiezasEncajadas++;
                }
            }
        }
    }
}
