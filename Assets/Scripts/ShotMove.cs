using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour {

    public float speed;

    public float minValueX;
    public float minValueZ;
    public float maxValueX;
    public float maxValueZ;


	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

    // Update is called once per frame
    void Update()
    {
        var x = this.transform.position.x;
        var z = this.transform.position.z;

        if (x > maxValueX || x < minValueX || z > maxValueZ || z < minValueZ)
        {
            Destroy(gameObject);
        }

        
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
