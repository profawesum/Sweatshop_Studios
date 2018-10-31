using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuFunctionality : MonoBehaviour
{


    public Camera main;
    public Camera Controls;
    public Camera Credits;


    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton, m_YourFourthButton, back;
    public Text credits, controls, credits2;

    void Start()
    {

        Controls.enabled = false;
        Credits.enabled = false;
        main.enabled = true;

        credits.enabled = false;
        credits2.enabled = false;
        controls.enabled = false;

        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
        m_YourSecondButton.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        m_YourThirdButton.onClick.AddListener(() => ButtonClicked(42));
        m_YourFourthButton.onClick.AddListener(Exit);
        back.onClick.AddListener(Back);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(1);
    }

    void Back()
    {

        controls.enabled = false;
        credits.enabled = false;
        credits2.enabled = false;

        Controls.enabled = false;
        Credits.enabled = false;
        main.enabled = true;


    }

    void TaskWithParameters(string message)
    {
        Controls.enabled = true;
        Credits.enabled = false;
        credits2.enabled = false;
        main.enabled = false;
        credits.enabled = false;
        controls.enabled = true;

        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {


        credits.enabled = true;
        controls.enabled = false;
        Controls.enabled = false;
        Credits.enabled = true;
        credits2.enabled = true;
        main.enabled = false;
    }
    void Exit()
    {

        Application.Quit();
    }
}