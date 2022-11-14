using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class juego : MonoBehaviour
{
    public Sprite[] Niveles;

    public GameObject MenuGanar;
    public GameObject PiezaSeleccionada;
    int capa = 1;    
    public int PiezasEncajadas = 0;

    void Start()
    {
        for (int i = 0;i < 36; i++)
        {
            //SceneManager.LoadScene("GameWin");
            //recorre las piezas, buscara su objeto hijo. Deoendiendo del lvl que estemos
            GameObject.Find("Pieza (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Niveles[PlayerPrefs.GetInt("Nivel")];
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//con mouse
        {
            //Si pulsamos el click, verifica si choco con algo que tenga la etiqueta puzzle
            //vemos si la pieza esta encajada y sino 
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<pieza>().Encajada)
                {
                    //guarda el objeto, miramos el script pieza y lo selecciona con get
                    //el grupo de pieza es igual a la capa 1 y la siguiente piezas que seleccionemos
                    //quedaran por encima de las piezas ya encajadas
                    PiezaSeleccionada = hit.transform.gameObject;
                    PiezaSeleccionada.GetComponent<pieza>().Seleccionada = true;
                    PiezaSeleccionada.GetComponent<SortingGroup>().sortingOrder = capa;
                    capa++;//por eso la capa sube un numero
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (PiezaSeleccionada != null)
            {
                PiezaSeleccionada.GetComponent<pieza>().Seleccionada = false;
                PiezaSeleccionada = null;
            }
        }
        if (PiezaSeleccionada != null)
        { //Calculamos el raton con esta linea y la pieza se arrastrara con nuestro mouse
            Vector3 raton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PiezaSeleccionada.transform.position = new Vector3(raton.x,raton.y,0);
        }             
        if (PiezasEncajadas == 36)
        {
           SceneManager.LoadScene("GameWin");
        }
    }
   /*  public void SiguienteNivel()
    {
        if(PlayerPrefs.GetInt("Nivel")<Niveles.Length-1)
        {
            PlayerPrefs.SetInt("Nivel", PlayerPrefs.GetInt("Nivel") + 1);
        }
        else
        {
            PlayerPrefs.SetInt("Nivel", 0);
        }
        SceneManager.LoadScene("Juego");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    } */
}