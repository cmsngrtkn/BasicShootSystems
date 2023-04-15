using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSystem : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform ShootPosition;
    public float shootSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(BulletPrefab, ShootPosition.position, ShootPosition.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = ShootPosition.up * shootSpeed;
        }
    }
}
