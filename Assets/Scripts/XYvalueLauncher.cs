using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class XYvalueLauncher : MonoBehaviour
{
    public InputField xValueField;
    public InputField yValueField;
    public InputField heightField;
    
    public TextMeshProUGUI xValueUsed;
    public TextMeshProUGUI yValueUsed;
    
    public string xValue;
    public string yValue;

    public float xNumber;
    public float yNumber;

    public string heightValue;
    public int heightNumber;

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

        heightValue = heightField.text;

        //heightNumber = float.Parse(heightValue);
        heightNumber = int.Parse(heightValue);

        xNumber = int.Parse(xValue);
        yNumber = int.Parse(yValue);
        // Also prints on Canvas the values you have used
        xValueUsed.text = "X Value: " + xNumber;
        yValueUsed.text = "Y Value: " + yNumber;

        // With these if statements the game requires you to input at least one (1) value over 0
        if (xNumber > 0 || yNumber > 0)
        {
            active = true;
        }
    }

}
