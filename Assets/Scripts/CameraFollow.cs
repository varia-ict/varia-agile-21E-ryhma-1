using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private XYvalueLauncher XYvalueLauncherScript;

    public GameObject injectorHUD;
    private GameObject player;

    public bool moveCamera = false;
    public bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        SetupStart();
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
        LaunchCheck();
        StatusChecker();
    }

    // Fetches the information for Tags and camera position
    void SetupStart()
    {
        player = GameObject.FindWithTag("Player");
        transform.position = new Vector3(24, 5, -50);
        transform.localEulerAngles = Vector3.zero;
    }

    // Executes camera follow command when "Bool (moveCamera)" is set to 'True'
    void Follow()
    {
        if (moveCamera)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 25);
            transform.localEulerAngles = Vector3.zero;
        }
    }

    // Communicates with "XYvalueLauncherScript" to get a Bool value
    void LaunchCheck()
    {
        XYvalueLauncherScript = GameObject.Find("xyInputInjector").GetComponent<XYvalueLauncher>();
        gameStart = XYvalueLauncherScript.active;
    }

    // Sets Boolean values to true and false for "moveCamera" for camera to follow, and "injectorHUD" on/off when "GO!" is Clicked
    void StatusChecker()
    {
        if (gameStart)
        {
            moveCamera = true;
            injectorHUD.SetActive(false);
        }
    }
}
