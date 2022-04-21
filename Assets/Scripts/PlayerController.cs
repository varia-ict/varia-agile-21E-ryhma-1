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
    public bool launched = false;

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
        yield return new WaitForSeconds(3);
        LaunchBird();
        launched = true;
        Debug.Log("Launch");
        if (go) Debug.Log("true");
        yield break;

    }
}
