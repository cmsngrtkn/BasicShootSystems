using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotScript : MonoBehaviour
{
    public Transform mermiCikisNoktasi;
    public GameObject Mermi;
    public float mermiHizi;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var Bullet = Instantiate(Mermi, mermiCikisNoktasi.position, mermiCikisNoktasi.rotation);
            Bullet.GetComponent<Rigidbody>().velocity = mermiCikisNoktasi.forward * mermiHizi;
        }
    }
}
