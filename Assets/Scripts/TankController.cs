using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;

    public TankController(TankModel model,TankView _tankView)
    {
        tankModel = model;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.getRigidBody();
        tankView.SetController(this);
        tankModel.SetController(this);
        
    }


    public void Move(float direction, float speed)
    {
        rb.velocity= tankView.transform.forward* direction*speed;
    }
    public void Rotate(float rotation, float speed)
    {
        Vector3 vector=new Vector3(0f,speed*rotation,0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
