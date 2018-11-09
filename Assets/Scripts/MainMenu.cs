using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button m_YourFirstButton, m_YourSecondButton;

    void Start()
    {
           m_YourFirstButton.onClick.AddListener(TaskOnClick);
           m_YourSecondButton.onClick.AddListener(Exit);
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
