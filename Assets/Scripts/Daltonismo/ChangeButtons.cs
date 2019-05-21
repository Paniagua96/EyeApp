using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButtons : MonoBehaviour
{
    public GameObject[] ButtonsTable;
    public GameObject Manager;
    public int questionNumber;
    public int correctQuestions;

    public void Start()
    {
        
    }

    public void Update()
    {
        correctQuestions = Manager.GetComponent<ManagerTest>().correctAnswer;
        questionNumber = Manager.GetComponent<ManagerTest>().numberQuestion;


        if (questionNumber == 1)
        {
            //pregunta 2
            ButtonsTable[0].SetActive(false);
            ButtonsTable[1].SetActive(true);
            

        }
        else if (questionNumber == 2)
        {
            ButtonsTable[1].SetActive(false);
            ButtonsTable[2].SetActive(true);
            
        }
        else if (questionNumber == 3)
        {
            ButtonsTable[2].SetActive(false);
            ButtonsTable[3].SetActive(true);
            
        }else if (questionNumber == 4 && correctQuestions <= 3)
        {
            ButtonsTable[3].SetActive(false);
            ButtonsTable[4].SetActive(true);
            ButtonsTable[5].SetActive(false);
        }
        else if (questionNumber == 4 && correctQuestions == 4)
        {
            ButtonsTable[3].SetActive(false);
            ButtonsTable[5].SetActive(true);
            ButtonsTable[4].SetActive(false);
        }
    }


}
