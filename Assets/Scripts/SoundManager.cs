using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public GameObject shot;
    public GameObject player;
    public GameObject player1;
    public GameObject _lumberJack;
    public GameObject _termite;

    public AudioClip shotClip;
    public static AudioClip shotClip1;
    public AudioClip playerClip;
    public AudioClip playerClip1;
    public AudioClip _lumberJackClip;
    public AudioClip _termiteClip;

    AudioSource shotSound;
    public static AudioSource shotSound1;
    AudioSource playerSound;
    AudioSource playerSound1;
    AudioSource lumberjack;
    AudioSource termite;

    bool firstSound = true;
    bool secondSound = false;
    bool play;

    public int playerSoundDelay;


	// Use this for initialization
	void Start ()
    {
        shotSound = shot.GetComponent<AudioSource>();
        shotSound1 = shotSound;
        playerSound = player.GetComponent<AudioSource>();
        playerSound1 = player1.GetComponent<AudioSource>();
        lumberjack = _lumberJack.GetComponent<AudioSource>();
        termite = _termite.GetComponent<AudioSource>();

        shotClip1 = shotClip;

        play = true;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(HealthBar.causeDamage==true)
        {
            LumberJack();
        }
        if(HealthBar.causeDamage == true)
        {
            Termite();
        }

        if (play == true)
        {
            StartCoroutine(PlayerSound());
        }
    }

    void LumberJack()
    {
        lumberjack.Play();
        //lumberjack.PlayOneShot(_lumberJackClip);
    }

    void Termite()
    {
        termite.Play();
        //termite.PlayOneShot(_termiteClip);
    }

    public static void ShotSound()
    {
        shotSound1.PlayOneShot(shotClip1);
    }

    IEnumerator PlayerSound ()
    {
        play = false;
        yield return new WaitForSeconds(playerSoundDelay);
        if (firstSound == true)
        {
            Debug.Log(playerSound.isPlaying);
            playerSound.Play();
            // playerSound.PlayOneShot(playerClip);
            firstSound = false;
            secondSound = true;
        }
        else if (secondSound == true)
        {
            playerSound1.PlayOneShot(playerClip1);
            firstSound = true;
            secondSound = false;
        }
        play = true;
    }
}
