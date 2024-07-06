using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankView;

    // Start is called before the first frame update
    void Start()
    {
        CreateController();
        //Instantiate(tankView.gameObject, transform.position, Quaternion.identity);
    }


    private void CreateController() {
        TankModel tankModel = new TankModel(30,30);
        TankController tankController = new TankController(tankModel, tankView);
}
    }


    
