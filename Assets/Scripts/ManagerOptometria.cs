using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ManagerOptometria : MonoBehaviour
{
    public GameObject[] imageTest;
    public ManagerTest managerTest;
    

    public void appearTest(int question)
    {
        imageTest[question ].SetActive(false);
        imageTest[question+1].SetActive(true);

        
    }


}
