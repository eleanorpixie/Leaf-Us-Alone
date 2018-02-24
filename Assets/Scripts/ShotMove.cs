using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShotMove : MonoBehaviour {

    public float speed;

    public float minValueX;
    public float minValueZ;
    public float maxValueX;
    public float maxValueZ;

    public new static string tag;

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
        if (other.gameObject.tag == "lumberjack1" || other.gameObject.tag == "termite1")
        {
            tag = other.gameObject.tag;

            PointSystem.AddPoints(10);

            if (PointSystem.points >= 1500)
            {
                //Winning scene name, change as needed
                SceneManager.LoadScene("Win");
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
