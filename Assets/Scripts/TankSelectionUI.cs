using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankSelectionUI : MonoBehaviour
{
    [SerializeField] public TankSpawner tankSpawner;
    [SerializeField] private GameObject blueButton;
    [SerializeField] private GameObject greenButton;
    [SerializeField] private GameObject redButton;


    private void Awake()
    {
        blueButton.SetActive(false); greenButton.SetActive(false); redButton.SetActive(false);
    }

    public void CreateRedTank()
    {
        tankSpawner.CreateController(TankType.Red);
        this.gameObject.SetActive(false);
        Debug.Log("Hello");
    }

    public void CreateBlueTank()
    {
        tankSpawner.CreateController(TankType.Blue);
        this.gameObject.SetActive(false);
    }
    public void CreateGreenTank()
    {
        tankSpawner.CreateController(TankType.Green);
        this.gameObject.SetActive(false);
    }

    public void CheckDetailForBlue()
    {
        blueButton.SetActive(true);
    }
    public void CheckDetailForGreen()
    {
        greenButton.SetActive(true);
    }
    public void CheckDetailForRed()
    {
        redButton.SetActive(true);
    }


    public void stopDetailForBlue()
    {
        blueButton.SetActive(false);
    }
    public void stopDetailForGreen()
    {
        greenButton.SetActive(false);
    }
    public void stopDetailForRed()
    {
        redButton.SetActive(false);
    }



}
