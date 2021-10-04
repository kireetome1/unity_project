using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenuControl : MonoBehaviour
{
    public void optionScreen()
    {
        SceneManager.LoadScene("optionMenu",LoadSceneMode.Additive);
    }
    public void exit()
    {
        Application.Quit();
    }
}
