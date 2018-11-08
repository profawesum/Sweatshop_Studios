using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour {

    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;

	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
		
	}

    public void Resume()
    {
        Debug.Log("Resume...");
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;

    }
    
    public void LoadMenu()
    {
        Debug.Log("Load Menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");

    }

    public void QuitGame()
    {
        Debug.Log("Quit Game...");
        Application.Quit();
    }
}


