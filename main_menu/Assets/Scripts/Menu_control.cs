using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_control : MonoBehaviour
{
    public void goToStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void goToOption()
    {
        SceneManager.LoadScene("Option");
    }
    public void goToCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void gotoExit()
    {
        Application.Quit();
    }
}
