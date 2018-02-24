using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {


    public GameObject shotSound;
    public GameObject creatureSound1;
    public GameObject creatureSound2;
    public GameObject lumberJack;
    public GameObject termite;

    AudioSource _shotSound;
    public static AudioSource _shotSound1;
    AudioSource _creatureSound1;
    AudioSource _creatureSound2;
    AudioSource _lumberJack;
    AudioSource _termite;

    [SerializeField]
    protected int soundDelay;

    bool firstSound = true;
    bool secondSound = false;

    // Use this for initialization
    void Start ()
    {
        _shotSound = shotSound.GetComponent<AudioSource>();
        _shotSound1 = _shotSound;
        _creatureSound1 = creatureSound1.GetComponent<AudioSource>();
        _creatureSound2 = creatureSound2.GetComponent<AudioSource>();
        _lumberJack = lumberJack.GetComponent<AudioSource>();
        _termite = termite.GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void LumberJack()
    {
        if(HealthBar.causeDamage==true&&TreeHealth.tag=="lumberjack1")
        {
            _lumberJack.Play();
        }
        else if(HealthBar.causeDamage == true && TreeHealth.tag == "termite1")
        {
            _termite.Play();
        }

        StartCoroutine(HeroSounds());
    }

    public static void ShotSount()
    {
        _shotSound1.Play();
    }

    IEnumerator HeroSounds()
    {
        yield return new WaitForSeconds(soundDelay);
        if(firstSound==true)
        {
            _creatureSound1.Play();
            firstSound = false;
            secondSound = true;
        }
        else if(secondSound==true)
        {
            _creatureSound2.Play();
            firstSound = true;
            secondSound = false;
        }
    }
}
