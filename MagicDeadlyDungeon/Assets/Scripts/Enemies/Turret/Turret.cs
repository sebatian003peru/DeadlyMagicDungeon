using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public GameObject bullet;
    public Transform Player;
    public Transform spawn;
    bool fire = false;
    float fireRate;
    public float fireRateCap;

	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(Player);

        if (fire) {
            Shoot();
        }
        else 
            fireRate += Time.deltaTime;

        if (fireRate >= fireRateCap)
            fire = true;

        
            
    }

    void Shoot()
    {
        Instantiate(bullet, spawn.position, spawn.rotation);
        fire = false;
        fireRate = 0;
    }

    
}
