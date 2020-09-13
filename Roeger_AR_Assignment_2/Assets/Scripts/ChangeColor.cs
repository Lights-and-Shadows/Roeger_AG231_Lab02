using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeColor : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btn;
    public Renderer ren;

    public List<Color> colors;

    public int curColor;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (curColor == colors.Count - 1)
            curColor = 0;
        else
            curColor++;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        colors = new List<Color>();
        Color red, green, blue, yellow, purple, orange, white;

        red = new Color(1f, 0f, 0f);
        green = new Color(0f, 1f, 0f);
        blue = new Color(0f, 0f, 1f);
        yellow = new Color(1f, 1f, 0f);
        purple = new Color(0.59f, 0f, 1f);
        orange = new Color(1f, 0.53f, 0f);
        white = new Color(1f, 1f, 1f);

        colors.Add(red);
        colors.Add(green);
        colors.Add(blue);
        colors.Add(yellow);
        colors.Add(purple);
        colors.Add(orange);
        colors.Add(white);

    }

    // Update is called once per frame
    void Update()
    {
        ren.material.SetColor("_EmissionColor", colors[curColor]);
    }
}
