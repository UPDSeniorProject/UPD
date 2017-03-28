using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RogoDigital.Lipsync;

public class MeganEvents : MonoBehaviour {
    static Animator anim;
    static AudioSource voice;
    public LipSync mouthMovement;
    public LipSyncData[] Log;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void changeAnimation(string animation)
    {
        if(animation == "Happy")
        {
            anim.SetTrigger("Happy");
        }
        if(animation == "Thoughtful")
        {
            anim.SetTrigger("Thoughtful");
        }
    }
    public void playAudio (string sound)
    {
        if (sound == "LipTest")
        {
            mouthMovement.Play(Log[0]);
        }
    }
}
