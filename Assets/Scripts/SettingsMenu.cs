using System.Collections.Generic;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float Volume)
    {
        audioMixer.SetFloat("volume", Volume);
    }
} 
