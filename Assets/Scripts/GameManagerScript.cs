using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System;

public class GameManagerScript : MonoBehaviour
{
    public GameObject WinScreenUI;
    public AudioManager audioManager;

    public static string playernamestr;
    public static string playernamestr1;
    public Text playername;
    public Text playername1;

    void Start()
    {   
        playername.text = playernamestr;
        playername1.text = playernamestr1;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void WinGame()
    {
        WinScreenUI.SetActive(true);
    }
        
    public void LoadNextScene()
    {
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
