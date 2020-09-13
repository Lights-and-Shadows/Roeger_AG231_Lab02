using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeColor : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btn, sphere;

    public List<Color> colors;

    public int curColor;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (curColor == colors.Count - 1)
            curColor = 0;
        else
            curColor++;
    }
    // Start is called before the first frame update
    void Start()
    {
        colors = new List<Color>();
        Color red, green, blue, yellow, purple, orange, white;

        red = new Color(255, 0, 0);
        green = new Color(0, 255, 0);
        blue = new Color(0, 0, 255);
        yellow = new Color(255, 255, 0);
        purple = new Color(150, 0, 255);
        orange = new Color(255, 150, 0);
        white = new Color(255, 255, 255);

        colors.Add(red);
        colors.Add(green);
        colors.Add(blue);
        colors.Add(yellow);
        colors.Add(purple);
        colors.Add(orange);
        colors.Add(white);

        sphere.GetComponent<Renderer>().material.SetColor("_EmissionColor", white);

    }

    // Update is called once per frame
    void Update()
    {
        sphere.GetComponent<Renderer>().material.SetColor("_EmissionColor", colors[curColor]);
    }
}
