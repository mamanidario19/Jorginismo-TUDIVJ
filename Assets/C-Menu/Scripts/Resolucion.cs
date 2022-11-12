using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Esto es text meshpro
using TMPro;

public class Resolucion : MonoBehaviour
{
    public Toggle toggle;
    //despeglable
    public TMP_Dropdown resolucionesDropDown;
    //todas las resoluciones que tenga el ordenador
    Resolution[] resoluciones;

    void Start()
    {
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
        RevisarResolucion();
    }

    void Update()
    {
    }

    public void ActiveFULLS(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;

    }

    public void RevisarResolucion()
    {
        //las resoluciones se detectan segun la computadora
        resoluciones = Screen.resolutions;
        //borra las opciones que vienen por defecto en el DropDown
        resolucionesDropDown.ClearOptions();
        //Crea una lista de opciones
        List<string> opciones = new List<string>();
        int resolucionActual = 0;

        for (int i = 0; i < resoluciones.Length; i++) //depende de cuantas resoluciones tiene
        {
            string opcion = resoluciones[i].width + " x " + resoluciones[i].height;
            opciones.Add(opcion);

            //Revisa si la opcion que guardamos es la que tenemos en el juego
            if (Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width &&
                resoluciones[i].height == Screen.currentResolution.height)
            {
                resolucionActual = i; //guarda la resolucion actual, osea la elegida
            }

        }

        resolucionesDropDown.AddOptions(opciones); //agrega todas las opciones de la lista
        resolucionesDropDown.value = resolucionActual; //detecta en que resolucion nos encontramos
        resolucionesDropDown.RefreshShownValue(); //actualiza la lista 
        //guarda la resolucion elegida en el despeglabe
        resolucionesDropDown.value = PlayerPrefs.GetInt("numeroResolucion", 0);

    }

    public void CambiarResolucion(int indiceResolucion)
    {
        //cmbia y guarda l num de resolucioness
        PlayerPrefs.SetInt("numeroResolucion", resolucionesDropDown.value);

        Resolution resolution = resoluciones[indiceResolucion];
        //cuando ya sepa a que resolucion cambiar, lo cambia
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

}