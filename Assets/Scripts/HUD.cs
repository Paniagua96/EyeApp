using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD: MonoBehaviour
{
    public ManagerTest managerTest;
    public Transform Person;
    public Transform Image;
    public Text distance;
    public Text correctAnswer;
    public Text correctAnswer2;
    public Text numberQuestion;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Person.position, Image.position);

        this.distance.text = "Distancia Imagen: " + distance.ToString("f0")+" m";
        correctAnswer.text = "Correctas: " + managerTest.correctAnswer;
        correctAnswer2.text = "Correctas: " + managerTest.correctAnswer;
        numberQuestion.text = "Pregunta: " + managerTest.numberQuestion;

    }
}
