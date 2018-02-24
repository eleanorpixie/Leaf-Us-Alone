using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    float startingHealth = 100;
    float currentHealth;
    public Image healthBarImage;
    public static bool causeDamage = false;
    public int damageAmt = 5;

    private bool coroutineRunning = false;

    [SerializeField]
    private Slider slider;

    [SerializeField]
    private Color fullColor = Color.green;

    [SerializeField]
    private Color emptyColor = Color.red;

	// Use this for initialization
	void Start ()
    {
        currentHealth = startingHealth;
        //StartCoroutine("DmgEverySecond");

        slider = GetComponent<Slider>();
        
    }

    private void Update()
    {

        if (causeDamage && !coroutineRunning)
        {
            StartCoroutine("DmgEverySecond");
        }
        //else
        //{
        //    //By putting this line here, it still goes quickly but it goes much slower than if this line were in the if statement above.
            
        //    StopCoroutine("DmgEverySecond");
            
        //}
    }

    IEnumerator DmgEverySecond()
    {
        coroutineRunning = true;
        CauseDamage(damageAmt);
        yield return new WaitForSeconds(.5f);
        coroutineRunning = false;

        
    }
    
    public void CauseDamage(float amountOfDamage)
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
