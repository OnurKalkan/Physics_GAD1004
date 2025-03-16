using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject projectile, projectileSample;
    public bool shoot = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && shoot == true)
        {
            shoot = false;
            projectile.transform.parent = null;
            projectile.GetComponent<Rigidbody>().isKinematic = false;
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            Invoke(nameof(CreateProjectile),0.25f);
        }
    }
    public void CreateProjectile()
    {
        GameObject newProjectile = Instantiate(projectileSample, transform);
        newProjectile.SetActive(true);
        projectile = newProjectile;
        shoot = true;
    }
}
