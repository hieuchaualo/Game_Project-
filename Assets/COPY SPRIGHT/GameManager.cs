using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance; 
    public AudioSource runAudioSource;
    public AudioClip runAudioClip;
    

    public void Awake() 
    {
        DontDestroyOnLoad(this);
        if(!Instance) //if (Instance == null)
        {
            Instance = this;
        }    
    }

    public void AudioRun()
    {
        runAudioSource.clip = runAudioClip;
        runAudioSource.Play();
    }

}