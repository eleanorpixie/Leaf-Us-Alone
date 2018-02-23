using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    float startingHealth = 100;
    float currentHealth;
    public Image healthBarImage;

    [SerializeField]
    private Slider slider;

    [SerializeField]
    private Color fullColor = Color.green;

    [SerializeField]
    private Color emptyColor = Color.red;

	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;
	}
	
    void CauseDamage(float amountOfDamage)
    {
        currentHealth -= amountOfDamage;
        SetSlider();
    }

    private void SetSlider()
    {
        slider.value = currentHealth;
        healthBarImage.color = Color.Lerp(emptyColor, fullColor, currentHealth / startingHealth);
    }
}
