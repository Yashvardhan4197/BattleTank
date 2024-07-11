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
        tankView.ChangeColor(tankModel.color);
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

    public void FireBullet(Transform Bullettransform,Rigidbody bulletRb,float bulletSpeed)
    {
       bulletRb.velocity=Bullettransform.forward*bulletSpeed;
    }

    public IEnumerator CameraShake(GameObject camera,float magnitude,float duration)
    {
        Vector3 originalPos=camera.transform.localPosition;
        float elapsedTime=0;
        while (elapsedTime < duration)
        {
            float x=Random.Range(-1,1)*magnitude;
            float y=Random.Range(-1, 1)*magnitude;
            camera.transform.localPosition=new Vector3(originalPos.x+x,originalPos.y+y,camera.transform.localPosition.z);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        camera.transform.localPosition = originalPos;
    }
}
