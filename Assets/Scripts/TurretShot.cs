
using UnityEngine;

public class TurretShot : MonoBehaviour {

    private Transform target;

    public float speed = 70f;

    public GameObject impactEffect;
    public void Seek(Transform _target)
    {
        target = _target;
    }
	// Update is called once per frame
	void Update ()
    {
		if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceTravellingPerFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceTravellingPerFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceTravellingPerFrame, Space.World);
	}

    void HitTarget()
    {
        GameObject effectInstance = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInstance, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
