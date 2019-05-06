using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;

public class Gun : MonoBehaviour
{
    [Header("Variables")]
    public float shootPower = 100f;
    public float fireRate = 15f;
    public GameObject bullet;
    public AeroplaneController player;

    private float nextTimeToFire = 0f;

    void FixedUpdate()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && !UIGameplayManager.Get().gameOver)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }

    public void Shoot()
    {
        GameObject shooted = Instantiate(bullet, transform.position, transform.parent.rotation);
        shooted.GetComponent<Rigidbody>().AddForce(transform.parent.forward * 
                                (shootPower + player.ForwardSpeed),ForceMode.VelocityChange);
        Destroy(shooted, 3f);
    }
}
