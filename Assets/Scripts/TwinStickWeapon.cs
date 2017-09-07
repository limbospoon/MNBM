using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinStickWeapon : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform projectileSpawnPoint;
    public float fireRate = 0.3f;

    private float lastFireTime = 0;

    public void Fire()
    {
        if(Time.time > lastFireTime)
        {
            Instantiate(projectile, projectileSpawnPoint.position, transform.rotation);
            lastFireTime = Time.time + fireRate;
        }
    }
}
