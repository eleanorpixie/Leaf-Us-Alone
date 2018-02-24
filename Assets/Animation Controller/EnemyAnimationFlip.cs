using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationFlip : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        
        Vector3 Position = transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
        SpriteRenderer spr = gameObject.GetComponent<SpriteRenderer>();
        if (gameObject.transform.position.x < 0)
        {
            spr.flipX = false;
        }
        else if (gameObject.transform.position.x > 0)
        {
            spr.flipX = true;
        }
    }
}
