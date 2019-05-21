using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class ManagerTest : MonoBehaviour
{
    public int correctAnswer = 0;
    public int numberQuestion = 1;

    public GameObject result;
    

    public void Start()
    {
        result.SetActive(false);
    }

    public void Update()
    {
        if (numberQuestion == 11)
        {
            result.SetActive(true);
            StartCoroutine(backMenu());
        }
    }


    public IEnumerator backMenu()
    {
        yield return new WaitForSeconds(10);
        Initiate.Fade("MainMenu", Color.black, 0.7f);
    }
}
