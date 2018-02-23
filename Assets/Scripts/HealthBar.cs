using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    float startingHealth = 100;
    float currentHealth;

    [SerializeField]
    private Slider slider;

    private Color fullColor = Color.green;
    private Color emptyColor = Color.red;

	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CauseDamage(float amountOfDamage)
    {
        currentHealth -= amountOfDamage;
        SetSlider();
    }

    private void SetSlider()
    {
        slider.value = currentHealth;

    }
}
