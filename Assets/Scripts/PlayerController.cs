using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private XYvalueLauncher XYvalueLauncherScript;
    private BranchRemove branchRemoveScript;
    
    private Rigidbody rb;
    
    public float speed;
    
    public float valueX;
    public float valueY;
   
    public bool go;
    public bool heightSet = false;
    public bool launched = false;

    public int heightLevel;
    public float tempPos;

    private GameObject player;
    private GameObject treeBranch;
    private BoxCollider treeCollider;

    public bool collidersOff = false;
    public bool collidersAreOff;

    public bool gameWin = false;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        StatusCheck();
        GetValues();
        OutOfBounds();
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

    // Setup for the valuse fetched from the XYvalueLauncherScript and setups RigidBody for the object to be launched /Also fetches Colliders for tree
    private void GetValues()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        XYvalueLauncherScript = GameObject.Find("xyInputInjector").GetComponent<XYvalueLauncher>();
        branchRemoveScript = GameObject.Find("tree_trunk").GetComponent<BranchRemove>();
        
        valueX = XYvalueLauncherScript.xNumber;
        valueY = XYvalueLauncherScript.yNumber;

        heightLevel = XYvalueLauncherScript.heightNumber;

        go = XYvalueLauncherScript.active;

        collidersAreOff = branchRemoveScript.collidersAreOff;
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
        collidersOff = true;
        if (collidersAreOff)
        {
            LaunchBird();
            launched = true;
        }
        Debug.Log("Launch");
        if (go) Debug.Log("true");
        yield break;

    }

    private void OnTriggerEnter(Collider other) // Collider for hitting the worm to set a trigger effects
    {
        if (other.gameObject.tag == "Worm")
        {
            gameWin = true;
        }
    }

    private void OutOfBounds() // Restarts if player is out of Bounds
    {
        if (player.transform.position.y <= -20.0f || player.transform.position.x >= 260)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
