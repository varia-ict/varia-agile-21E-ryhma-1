using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class XYvalueLauncher : MonoBehaviour
{
    public InputField xValueField;
    public InputField yValueField;
    
    public TextMeshProUGUI xValueUsed;
    public TextMeshProUGUI yValueUsed;
    
    public string xValue;
    public string yValue;

    public float xNumber;
    public float yNumber;

    public bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function for getting and converting values for the HUD and launch forces, also sets a active/go Bool to true once "GO!" is clicked
    public void OnSubmit()
    {
        xValue = xValueField.text;
        yValue = yValueField.text;

        xNumber = int.Parse(xValue);
        yNumber = int.Parse(yValue);

        xValueUsed.text = "X Value: " + xNumber;
        yValueUsed.text = "Y Value: " + yNumber;


        if (xNumber > 0 || yNumber > 0)
        {
            active = true;
        }
    }

}