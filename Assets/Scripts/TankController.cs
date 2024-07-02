using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel model,TankView tankView)
    {
        this.tankModel = model;
        this.tankView = tankView;

        GameObject.Instantiate(tankView.gameObject);

        this.tankView.SetController(this);
        this.tankModel.SetController(this);
    }
}
