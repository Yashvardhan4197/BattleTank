using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movementSpeed;
    public float RotationSpeed;


    public TankModel(float movementSpeed, float rotationSpeed)
    {
        this.movementSpeed = movementSpeed;
        this.RotationSpeed = rotationSpeed;
    }
    public void SetController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
