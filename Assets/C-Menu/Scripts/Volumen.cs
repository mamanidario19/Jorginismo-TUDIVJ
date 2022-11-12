using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;
    public Image imagenMax;
    // Start is called before the first frame update
    void Start()
    {
        //Mantiene guardado la posicion de slider
        //PlayersPrefs es una variable del unity, al iniciar va a tener el volumen en 0.5f
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        //Con esto sacamos el volumen al juego
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
        RevisarSiEstoyMax();
    }

     public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
        RevisarSiEstoyMax();
    }

    private void RevisarSiEstoyMute()
    {
        if (sliderValue == 0)
        {
            //Imagen que estoy silenciado o no
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled = false;
        }

    }
    private void RevisarSiEstoyMax()
    {
        if (sliderValue == 1)
        {
            //Imagen que estoy silenciado o no
            imagenMax.enabled = true;
        }
        else
        {
            imagenMax.enabled = false;
        }

    }
}
