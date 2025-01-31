using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    CharacterController cc;

    void Start ()
    {
        cc = GetComponent<CharacterController>();
        
        // Make sure the audio does not play after the initialisation is complete
        GetComponent<AudioSource>().Stop();
    }
 
    void Update()
    {

        // If the user is moving play sound
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        }

        // If the user is not moving stop sound
        if (cc.isGrounded == true && cc.velocity.magnitude == 0f && GetComponent<AudioSource>().isPlaying == true)
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
