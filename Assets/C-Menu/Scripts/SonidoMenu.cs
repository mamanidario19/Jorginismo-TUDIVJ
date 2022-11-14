using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoMenu : MonoBehaviour {
    public AudioSource sound;
    public AudioClip soundHover;
    public AudioClip soundClick;

    public void SoundButtonHover()//Esta funcion es llamada desde el Boton a traves del componente Event Trigger.
    {
        //Eligimos que sonido sonara
        sound.PlayOneShot (soundHover);
        /* //Lo desactivo y activo para que genere el sonido
        sound.enabled = false;
        sound.enabled = true; */
    }
     public void SoundButtonClick()//Esta funcion es llamada desde el Boton a traves del componente Event Trigger.
    {
        //Eligimos que sonido sonara
        sound.PlayOneShot (soundClick);
    }

}
