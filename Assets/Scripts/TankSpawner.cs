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
        CreateController();
        //Instantiate(tankView.gameObject, transform.position, Quaternion.identity);
    }


    private void CreateController() {
        TankModel tankModel = new TankModel(tank[2].movement, tank[2].speed, tank[2].type, tank[2].color);
        TankController tankController = new TankController(tankModel, tankView);
}
    }


    
