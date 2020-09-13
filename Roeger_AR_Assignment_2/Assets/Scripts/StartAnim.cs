using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class StartAnim : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject btn, sphere;
    public Animator anim;

    public bool started;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (started)
            started = false;
        else
            started = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        anim = sphere.GetComponent<Animator>();

        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
            anim.Play("sphere_animation");
        else
            anim.Play("none");
    }
}
