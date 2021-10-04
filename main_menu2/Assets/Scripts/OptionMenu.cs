using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{

    public Toggle fullscreenTog, vsyncTog;

    public ResItem[] resolution;

    public int selectedResolution;

    public Text resolutionLabel;

    // Start is called before the first frame update
    void Start()
    {

        fullscreenTog.isOn = Screen.fullScreen;

        if(QualitySettings.vSyncCount == 0 )
        {
            vsyncTog.isOn = false;
        }else
        {
            vsyncTog.isOn = true;
        }

        //search for resolution in list
        bool foundRes = false;
        for(int i = 0; i < resolution.Length; i++)
        {
            if(Screen.width == resolution[i].horizontal && Screen.height == resolution[i].vertical)
            {
                foundRes = true;

                selectedResolution = i;

                UpdateResolution();
            }
        }

        if(!foundRes)
        {
            resolutionLabel.text = Screen.width.ToString() + " X " + Screen.height.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResLeft()
    {
        selectedResolution--;
        if(selectedResolution < 0)
        {
            selectedResolution = 0;
        }
        UpdateResolution();
    }

    public void ResRight()
    {
        selectedResolution++;
        if(selectedResolution > resolution.Length - 1 )
        {
            selectedResolution = resolution.Length - 1;
        }
        UpdateResolution();
    }

    public void UpdateResolution()
    {
        resolutionLabel.text = resolution[selectedResolution].horizontal.ToString() + " X " + resolution[selectedResolution].vertical.ToString();
    }
    public void ApplyGraphics()
    {
        //apply fullscreen
        //Screen.fullScreen = fullscreenTog.isOn;

        //vsync
        if(vsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }else
        {
            QualitySettings.vSyncCount = 0;
        }

        //set resolution
        Screen.SetResolution(resolution[selectedResolution].horizontal, resolution[selectedResolution].vertical, fullscreenTog.isOn);
    }
}

[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;
}