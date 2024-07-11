using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyUI : MonoBehaviour
{


    public void OnPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void OnExit()
    {
        Application.Quit();
    }
}
