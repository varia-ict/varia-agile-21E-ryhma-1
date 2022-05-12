using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private XYvalueLauncher XYvalueLauncherScript;
    
    private Rigidbody rb;
    
    public float speed;
    
    public float valueX;
    public float valueY;
   
    public bool go;
    public bool heightSet = false;
    public bool launched = false;

    public int heightLevel;
    public float tempPos;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        StatusCheck();
        GetValues();
    }

    // Function will set the bird launching height in the range of three levels
    private void SetHeight()
    {
        if (!launched && !heightSet)
        {
            Debug.Log("Nakki");
            switch (heightLevel)
            {
                case 1:
                    transform.position = new Vector3(0f, 0.22f, 0f);
                    break;
                case 2:
                    transform.position = new Vector3(0f, 3.60f, 0f);
                    break;
                case 3:
                    transform.position = new Vector3(0f, 6.70f, 0f);
                    break;
                default:
                    transform.position = new Vector3(0f, 0.22f, 0f);
                    break;
            }
            heightSet = true;
        }
    }

    // If statement for the LaunchBird function to be executed once Bool values are set to True and False
    private void LaunchBird()
    {
        if (go && !launched)
        {
            rb.AddForce(new Vector3(valueX, valueY, 0), ForceMode.Impulse);
        }
    }

    // Setup for the valuse fetched from the XYvalueLauncherScript and setups RigidBody for the object to be launched
    private void GetValues()
    {
        rb = GetComponent<Rigidbody>();

        XYvalueLauncherScript = GameObject.Find("xyInputInjector").GetComponent<XYvalueLauncher>();

        valueX = XYvalueLauncherScript.xNumber;
        valueY = XYvalueLauncherScript.yNumber;

        heightLevel = XYvalueLauncherScript.heightNumber;

        go = XYvalueLauncherScript.active;
    }

    // Satus checker for the Boolean "Go" and initiation for the StartCoroutine Countdown
    private void StatusCheck()
    {
        if (go == true)
        {
            StartCoroutine("Countdown3");
            Debug.Log("yes");
        }
    }

    // Countdown for the launch of the Object (Bird) then executes the function "LaunchBird" and sets Bool (launched) to true
    IEnumerator Countdown3()
    {
        SetHeight();
        yield return new WaitForSeconds(3);
        LaunchBird();
        launched = true;
        Debug.Log("Launch");
        if (go) Debug.Log("true");
        yield break;

    }
}
