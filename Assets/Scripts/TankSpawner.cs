using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankView;

    [System.Serializable]
    class Tank
    {
        public float movement;
        public float speed;
        public TankType type;
        public Material color;
    }


    [SerializeField] private List<Tank> tank;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(tankView.gameObject, transform.position, Quaternion.identity);
    }


    public void CreateController(TankType tankType) {

        if (tankType == TankType.Red)
        {
            TankModel tankModel = new TankModel(tank[0].movement, tank[0].speed, tank[0].type, tank[0].color);
            TankController tankController = new TankController(tankModel, tankView);
            
        }
        else if(tankType == TankType.Green)
        {
            TankModel tankModel = new TankModel(tank[1].movement, tank[1].speed, tank[1].type, tank[1].color);
            TankController tankController = new TankController(tankModel, tankView);
           
        }
        else if( tankType == TankType.Blue)
        {
            TankModel tankModel = new TankModel(tank[2].movement, tank[2].speed, tank[2].type, tank[2].color);
            TankController tankController = new TankController(tankModel, tankView);
       
        }
}
    }


    
