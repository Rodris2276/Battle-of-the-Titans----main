using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject WinScreenUI;
    public Text PlayerName;

    void Start()
    {
        //PlayerName.text = 
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
