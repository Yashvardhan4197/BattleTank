using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletbehaviour : MonoBehaviour
{
    int start = 0;
    [SerializeField]private GameObject Bulletexplosion;
    private void Awake()
    {
        Bulletexplosion.SetActive(false);
        Destroy(gameObject, 5f);   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ((start == 0))
        {
            GameObject bp = Instantiate(Bulletexplosion);
            bp.transform.position = gameObject.transform.position;
            bp.SetActive(true);
            Destroy(bp, 3f);
            start = 1;
        }
        Destroy(this.gameObject,0.1f);
    }
    
}
