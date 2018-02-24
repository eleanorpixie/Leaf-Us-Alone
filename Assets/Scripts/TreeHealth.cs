using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHealth : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "termite1" || other.gameObject.tag == "lumberjack1")
        {
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
