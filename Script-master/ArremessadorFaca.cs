using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArremessadorFaca : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource somFacaBaixo;

    float fireRate;
	float nextFire;

	// Use this for initialization
	void Start () {
		fireRate = 3f;
		nextFire = Time.time;
        somFacaBaixo = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfTimeToFire ();
	}

	void CheckIfTimeToFire()
	{
		if (Time.time > nextFire) {
			Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            somFacaBaixo.Play();
			nextFire = Time.time + fireRate;
		}
		
	}

    void Shoot ()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
