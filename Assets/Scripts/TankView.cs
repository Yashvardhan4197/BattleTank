using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView: MonoBehaviour { 

    private TankController tankController;
    [SerializeField]public Rigidbody rb;

    [SerializeField] private MeshRenderer[] mesh;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform fireTransform;
    private GameObject cam;
    [SerializeField] private GameObject TankStartexplosion2;

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
        cam.transform.position = new Vector3(0f, 10f, -7.56f);
        this.cam = cam;
        
    }
    private void Update()
    {
        Movement();
        if (movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }
        else if (rotate!=0)
        {
            tankController.Rotate(rotate, tankController.GetTankModel().RotationSpeed);
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bullet1=Instantiate(bullet,fireTransform.position,fireTransform.rotation);
            GameObject exp = Instantiate(TankStartexplosion2, fireTransform.position,fireTransform.rotation);
            StartCoroutine(tankController.CameraShake(cam, tankController.GetTankModel().cameraShakeMagnitude, tankController.GetTankModel().cameraShakeDuration));
            tankController.FireBullet(bullet1.transform,bullet1.GetComponent<Rigidbody>(),tankController.GetTankModel().bulletSpeed);
            Destroy(exp,2f);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {

        }
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
    }

    public void ChangeColor(Material color)
    {
        for(int i=0; i < mesh.Length;i++)
        {
            mesh[i].material = color;
        }
    }

    public void setRigidBody(Rigidbody r)
    {
        rb = r;
    }
}
