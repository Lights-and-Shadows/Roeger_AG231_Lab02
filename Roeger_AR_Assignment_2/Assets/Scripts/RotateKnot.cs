using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RotateKnot : MonoBehaviour, IVirtualButtonEventHandler
{
    public bool isRotating;

    public GameObject knot, btn;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        isRotating = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        isRotating = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
            knot.transform.Rotate(knot.transform.forward, 1f);
    }
}
