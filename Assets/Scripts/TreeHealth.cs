using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHealth : MonoBehaviour {
    public static string tag=null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "termite1" || other.gameObject.tag == "lumberjack1")
        {
            tag = other.gameObject.tag;
            HealthBar.causeDamage = true;
        }
        else
        {
            HealthBar.causeDamage = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "termite1" || other.gameObject.tag == "lumberjack1")
        {
            HealthBar.causeDamage = false;
        }
    }
}
