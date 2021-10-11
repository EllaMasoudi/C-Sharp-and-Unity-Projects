using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    void Update()
    {
        //Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
         
        }
        
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
