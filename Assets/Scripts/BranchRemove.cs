using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchRemove : MonoBehaviour
{
    private PlayerController playerControllerScript;

    public bool collidersOff = false;
    public bool collidersAreOff = false;
    // private BoxCollider treeCollider;
    public GameObject treeColliders;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BoolUpdate();
    }

    private void BoolUpdate() // Finds player with tag also fetches the Script where to get the Boll value
    {
        // playerControllerScript = GameObject.Find("testbird2").GetComponent<PlayerController>();
        player = GameObject.FindWithTag("Player");
        playerControllerScript = player.GetComponent<PlayerController>();
        

        collidersOff = playerControllerScript.collidersOff;

        // treeCollider = GetComponent<BoxCollider>();
        
        if (collidersOff) // Once fetched Bool is set to true, Collider(EmptyGameObject)Group will be turned off
        {
            treeColliders.SetActive(false);
            collidersAreOff = true;
        }
    }
}
