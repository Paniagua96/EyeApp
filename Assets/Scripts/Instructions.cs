using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public int numberScene;
    public GameObject InstructionsOptometriaCanvas;
    public GameObject InstructionsDaltonismoCanvas;
    public GameObject InstructionsMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        InstructionsOptometriaCanvas.SetActive(false);
        InstructionsDaltonismoCanvas.SetActive(false);
        InstructionsMenuCanvas.SetActive(false);

    }

    public void ShowInstructions()
    {

      
            if (numberScene==1&&InstructionsOptometriaCanvas.activeInHierarchy)
            {
                InstructionsOptometriaCanvas.SetActive(false);
            }
            else if(numberScene==2 && InstructionsDaltonismoCanvas.activeInHierarchy)
            {
                InstructionsDaltonismoCanvas.SetActive(false);
            }
            else if(numberScene == 0&& InstructionsMenuCanvas.activeInHierarchy)
            {
                InstructionsMenuCanvas.SetActive(false);
            }

            if (numberScene == 1 && !InstructionsOptometriaCanvas.activeInHierarchy)
            {
                InstructionsOptometriaCanvas.SetActive(true);
            }
            else if (numberScene == 2 && !InstructionsDaltonismoCanvas.activeInHierarchy)
            {
                InstructionsDaltonismoCanvas.SetActive(true);
            }
            else if (numberScene == 0 && !InstructionsMenuCanvas.activeInHierarchy)
            {
                InstructionsMenuCanvas.SetActive(true);
            }


    }

}
