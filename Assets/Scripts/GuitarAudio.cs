using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarAudio : MonoBehaviour
{
    public AudioSource guitar_audio;


    void OnTriggerEnter(Collider other)
    {
        PlayerEnter();
    }


    void OnTriggerExit(Collider other)
    {
        PlayerExit();
    }


    void PlayerEnter()
    {
        // Play the guitar audio
        guitar_audio.Play();
    }


    void PlayerExit()
    {
        // Stop the guitar audio
        guitar_audio.Stop();
    }
}