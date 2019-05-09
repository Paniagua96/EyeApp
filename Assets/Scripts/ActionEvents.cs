using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionEvents: MonoBehaviour
{
    public ManagerTest managerTest;

    public void WasCorrectAnswer()
    {
        managerTest.correctAnswer++;
        managerTest.numberQuestion++;
    }

    public void WasIncorrectAnswer()
    {
        managerTest.numberQuestion++;
    }

    public void RestartSceneTestOptometrico()
    {
        Initiate.Fade("TestOptometrico",Color.black, 0.7f);
        //SceneManager.LoadScene("TestOptometrico");
    }


    public void RestartSceneTestDaltonismo()
    {
        //SceneManager.LoadScene("TestDaltonismo");
        Initiate.Fade("TestDaltonismo", Color.black, 0.7f);
    }

    public void RestartSceneMainMenu()
    {
        //SceneManager.LoadScene("TestDaltonismo");
        Initiate.Fade("MainMenu", Color.black, 0.7f);
    }



    public void Exit()
    {
        Application.Quit();
    }

}
