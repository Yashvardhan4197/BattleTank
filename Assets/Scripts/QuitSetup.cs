using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitSetup : MonoBehaviour
{
    [SerializeField]public GameObject quitButton;
    bool press = true;
    // Start is called before the first frame update
    void Start()
    {
        quitButton.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&press==true)
        {
           quitButton.SetActive(true);
            Time.timeScale = 0;
            press = false;
        }
        else if(Input.GetKeyDown(KeyCode.Escape)&&press==false)
        {
            quitButton.SetActive(false);
            Time.timeScale = 1 ;
            press = true;
        }
    }

    public void onExit()
    {
        Application.Quit();
    }
}
