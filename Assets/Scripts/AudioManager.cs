using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [Header("--------- Audio Source ---------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--------- Audio Clip ---------")]
    public AudioClip background;
    public AudioClip button;
    public AudioClip hover_button;
    public AudioClip death;
    public AudioClip victory;
    public AudioClip jump;
    public AudioClip run;
    public AudioClip menu;

    private void Start()
    {
        
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void StopSFX()
    {
        _ = musicSource.mute;
    }
}

