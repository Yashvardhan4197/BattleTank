using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movementSpeed;
    public float RotationSpeed;
    public Material color;
    public TankType tankType;

    public TankModel(float movementSpeed, float rotationSpeed,TankType tankType, Material color)
    {
        this.movementSpeed = movementSpeed;
        this.RotationSpeed = rotationSpeed;
        this.tankType = tankType;
        this.color = color;
    }
    public void SetController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
