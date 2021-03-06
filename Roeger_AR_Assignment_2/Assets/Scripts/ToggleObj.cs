﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ToggleObj : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject toggleBtn, knot;

    public bool isToggled;
    // Start is called before the first frame update
    
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (isToggled)
            isToggled = false;
        else
            isToggled = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    void Start()
    {
        toggleBtn = GameObject.Find("btnToggleKnot");
        toggleBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        isToggled = false;
    }

    void Update()
    {
        if (isToggled)
            knot.SetActive(true);
        else
            knot.SetActive(false);
    }
}
