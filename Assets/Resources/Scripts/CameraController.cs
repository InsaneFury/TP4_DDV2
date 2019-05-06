using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : Singleton<CameraController>
{
    [Header("Settings")]
    public GameObject firstCam;
    public GameObject thirdCam;

    [HideInInspector]
    public bool firstPersonMode = false;

    public override void Awake()
    {
        base.Awake();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            firstPersonMode = !firstPersonMode;
            changeCamMode(); 
        }    
    }

    public void changeCamMode()
    {
        if (firstPersonMode)
        {
            firstCam.SetActive(true);
            thirdCam.SetActive(false);
        }
        else
        {
            thirdCam.SetActive(true);
            firstCam.SetActive(false);
        }
    }
}
