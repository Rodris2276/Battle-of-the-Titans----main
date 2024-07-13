using UnityEngine.SceneManagement;
using System.Collections.Generic;
using Unity.VisualScripting;
using System.Collections;
using UnityEngine;
using System.Text;
using System;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public AudioSource musicSource;
    public GameObject pauseMenuUI;

    void Start()
    {
        musicSource = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            } 
            else
            {
                Pause();
            }
        }
    }

    public void StopSFX()
    {
        musicSource.Stop();
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        if(UnityEditor.EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        
        else
        {
            Application.Quit();
        }
        
    }
}
