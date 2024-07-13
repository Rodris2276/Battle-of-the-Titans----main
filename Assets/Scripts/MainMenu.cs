using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public InputField playername;
    public InputField playername1;
    public AudioManager audioManager;
    public AudioSource MenuSource;

    private void Start()
    {
        MenuSource = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void PlayGame ()
    {
        GameManagerScript.playernamestr1 = playername1.text;
        GameManagerScript.playernamestr1 = playername.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        if(UnityEditor.EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }



}
