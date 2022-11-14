using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public GameObject objectOnOff;
    public GameObject iconoON;
    public GameObject iconoOF;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            objectOnOff.SetActive(false);
            iconoOF.SetActive(false);
            iconoON.SetActive(true);
            
        }
         if (Input.GetKeyDown(KeyCode.E))
        {
            objectOnOff.SetActive(true);
            iconoON.SetActive(false);
            iconoOF.SetActive(true);
        }
    }
}
