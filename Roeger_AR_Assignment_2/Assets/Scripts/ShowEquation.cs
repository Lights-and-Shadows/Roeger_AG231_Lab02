using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ShowEquation : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btn, equation;

    public bool showMe;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (showMe)
            showMe = false;
        else
            showMe = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        showMe = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (showMe)
            equation.SetActive(true);
        else
            equation.SetActive(false);
    }
}
