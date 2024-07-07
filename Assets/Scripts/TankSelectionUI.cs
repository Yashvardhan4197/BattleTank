using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelectionUI : MonoBehaviour
{
    [SerializeField] public TankSpawner tankSpawner;
    
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
}
