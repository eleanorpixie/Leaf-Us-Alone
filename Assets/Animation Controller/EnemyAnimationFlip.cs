using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{    
    private SpriteRenderer spr;
    private Animator anim;

    private Rigidbody rig;

	private void Start () {
        
        spr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
	}
	
	private void Update ()
    {
        if (this.transform.position.x < 0)
        {
            spr.flipX = false;
        }
        else if (this.transform.position.x > 0)
        {
            spr.flipX = true;
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tree")
        {
            anim.SetBool("IsAttacking", true);
        }
    }
}
