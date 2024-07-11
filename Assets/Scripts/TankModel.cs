using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    public float movementSpeed;
    public float RotationSpeed;
    public float bulletSpeed;
    public Material color;
    public TankType tankType;
    public float cameraShakeMagnitude;
    public float cameraShakeDuration;
    public TankModel(float movementSpeed, float rotationSpeed,TankType tankType, Material color, float bulletSpeed,float cameraShakeMagnitude, float cameraShakeDuration)
    {
        this.movementSpeed = movementSpeed;
        this.RotationSpeed = rotationSpeed;
        this.tankType = tankType;
        this.color = color;
        this.bulletSpeed = bulletSpeed;
        this.cameraShakeMagnitude = cameraShakeMagnitude;
        this.cameraShakeDuration = cameraShakeDuration;
    }
    public void SetController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
