using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public static SoundController instance;
    AudioSource BackGroundAudio;
    
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
    private void Start()
    {
        BackGroundAudio = GetComponent<AudioSource>();
        BackGroundAudio.Play();
    }


}
