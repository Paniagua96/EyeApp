using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public ManagerTest managerTest=new ManagerTest();
    public Text resultOptometria;

    public void Update()
    {
        showResultOptometria(managerTest.correctAnswer);
    }

    public void showResultOptometria(int correctAnswer)
    {
        switch (correctAnswer)
        {
            case 1:
                resultOptometria.text = "Necesitas lentes , agudeza visual: " +
                                        " 20/200";
                break;
            case 2:
                resultOptometria.text = "Necesitas lentes , agudeza visual: " +
                                        " 20/100";
                break;
            case 3:
                resultOptometria.text = "Necesitas lentes , agudeza visual: " +
                                        " 20/70";
                break;
            case 4:
                resultOptometria.text = "Necesitas lentes , agudeza visual: " +
                                        " 20/50";
                break;
            case 5:
                resultOptometria.text = "Necesitas lentes , agudeza visual: " +
                                        " 20/40";
                break;
            case 6:
                resultOptometria.text = "Necesitas lentes , agudeza visual: " +
                                        " 20/30";
                break;
            case 7:
                resultOptometria.text = "Tienes vista normal, estas bien, agudeza visual: " +
                                        " 20/25";
                break;
            case 8:
                resultOptometria.text = "Tienes vista normal, estas bien, agudeza visual: " +
                                        " 20/20";
                break;
            case 9:
                resultOptometria.text = "Excelente vista no necesitas lentes, agudeza visual:  " +
                                        " 20/15";
                break;
            case 10:
                resultOptometria.text = "Excelente vista no necesitas lentes, agudeza visual:  " +
                                        " 20/13";
                break;
            case 11:
                resultOptometria.text = "Excelente vista no necesitas lentes, agudeza visual: " +
                                        "20/10";
                break;
           
        }
    }

} 
