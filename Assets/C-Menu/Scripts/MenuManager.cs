using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void SceneGame(){
        SceneManager.LoadScene("Game");
        //SceneManager.LoadScene(1);
    }
    public void SceneOptions(){
        SceneManager.LoadScene("Options");
    }
    public void SceneExit(){
        Debug.Log("Cerramos aplicación");
        Application.Quit();
    }
}
