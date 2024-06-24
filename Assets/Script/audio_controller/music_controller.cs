using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_controller : MonoBehaviour
{
    [SerializeField] private AudioSource rabbithouse;

    void Start()
    {
        Invoke("Play",setting.start_time);
        
    }
    void Play()
    {
        rabbithouse.Play();
    }
}
