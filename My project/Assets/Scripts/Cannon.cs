using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            Invoke("Shoot", 0.5f);
            Invoke("Shoot", 1f);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            Invoke("Shoot", 0.5f);
            Invoke("Shoot", 1f);
            Invoke("Shoot", 1.5f);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Invoke("Shoot", 0.5f);
            Invoke("Shoot", 1f);
            Invoke("Shoot", 1.5f);
            Invoke("Shoot", 2f);
        }
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 0f);
        }
    }

    private void ResetShoot()
    {
        canShoot = true;
    }
}
