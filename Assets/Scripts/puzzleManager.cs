using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzleManager : MonoBehaviour
{
   public GameObject act1;
   public GameObject act2;
   public GameObject act3;


void OnTriggerEnter (Collider other) 
{
    //pregunta si estoy adentro del 1,2,3 activador, para mostrar el play de su puzzle
    if (other.tag == "activador1"){
      //  Debug.Log("aparece boton play1 en escena");
        act1.SetActive(true);
    }

      if (other.tag == "activador2"){
        //Debug.Log("aparece boton play2 en escena");
        act2.SetActive(true);
    }

    if (other.tag == "activador3"){
     //   Debug.Log("aparece boton play3 en escena");
        act3.SetActive(true);
    }
    
}

void OnTriggerExit(Collider other)
{
    if (other.tag == "activador1"){
      //  Debug.Log("me sali de activador 1");
        act1.SetActive(false);
    }

    if (other.tag == "activador2"){
       // Debug.Log("me sali de activador 2");
        act2.SetActive(false);
    }

    if (other.tag == "activador3"){
     //   Debug.Log("me sali de activador 3");
        act3.SetActive(false);
    }
}


}
