using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizunomanager : MonoBehaviour
{
    public GameObject[] Levels;
    int currentLevel;

    public void correctAnswer()
    {
        if (currentLevel +1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);
            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
    }
    public void incorrectAnswer(){
        
    }
    
}
