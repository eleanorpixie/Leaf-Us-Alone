 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public Transform target;

    [Header("Attributes")]
    public float range = 15f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    [Header("Unity Setup Fields")]
    public string enemyTag1 = "lumberjack1";
    public string enemyTag2 = "termite1";

    public Transform partToRotate;
    public float turnSpeed = 10f;

    public GameObject shotPrefab;
    public Transform firePoint;


    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
	}

    void UpdateTarget()
    {
        GameObject[] enemies1 = GameObject.FindGameObjectsWithTag(enemyTag1);
        GameObject[] enemies2 = GameObject.FindGameObjectsWithTag(enemyTag2);
        float shortestDitance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach(GameObject enemy in enemies1)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDitance)
            {
                shortestDitance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if(nearestEnemy != null && shortestDitance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(target == null)
        {
            return;
        }
        //Target lock and rotation
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if(fireCountdown <= 0)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
	}

    void Shoot()
    {
        GameObject turretShot = (GameObject)Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
        TurretShot turretBullet = turretShot.GetComponent<TurretShot>();
        if(turretBullet != null)
        {
            turretBullet.Seek(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
