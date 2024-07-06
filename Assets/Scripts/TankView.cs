using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView: MonoBehaviour { 

    private TankController tankController;
    [SerializeField]public Rigidbody rb;

    float movement = 0;
    float rotate = 0;
    public void SetController(TankController tankController)
    {
        this.tankController = tankController; 
    }

    public Rigidbody getRigidBody()
    {
        return rb;
    }

    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -5.58f);
    }
    private void Update()
    {
        Movement();
        if (movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }
        if (rotate!=0)
        {
            tankController.Rotate(rotate, tankController.GetTankModel().RotationSpeed);
        }
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
    }

    public void setRigidBody(Rigidbody r)
    {
        rb = r;
    }
}
