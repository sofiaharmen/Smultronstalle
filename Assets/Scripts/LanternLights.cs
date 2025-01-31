using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternLights : MonoBehaviour
{
    public Light lanternLight;


    void Awake()
    {
        lanternLight.enabled = false;
    }


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
        lanternLight.enabled = true;
    }

    void PlayerExit()
    {
        lanternLight.enabled = false;
    }
}
