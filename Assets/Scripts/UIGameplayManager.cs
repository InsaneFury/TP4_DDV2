using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.Vehicles.Aeroplane;

public class UIGameplayManager : Singleton<UIGameplayManager>
{
    [Header("UISettings")]
    public GameObject FirstPersonUI;
    public AeroplaneController player;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI altitudeText;
    public bool gameOver = false;

    CameraManager camManager;

    public override void Awake()
    {
        base.Awake();
    }

    void Start()
    {
        camManager = CameraManager.Get();
        speedText.text = "0000";
        altitudeText.text = "0000";
    }

    void Update()
    {
        speedText.text = Mathf.Round(player.ForwardSpeed).ToString();
        altitudeText.text = Mathf.Round(player.Altitude).ToString();
        FirstPersonUI.SetActive(camManager.firstPersonMode);
    }
}


