using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brillo : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image panelBrillo;
    
    void Start()
    {
        //guardamos un valor en unity, brillo en 0,5f
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        //alfa - no cambia rgb pero si el slider value que es alfa 
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);
    }

    void Update()
    {
        
    }
     public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("brillo", sliderValue);
        panelBrillo.color = new Color(panelBrillo.color.r , panelBrillo.color.g, panelBrillo.color.b, slider.value);
    }
}