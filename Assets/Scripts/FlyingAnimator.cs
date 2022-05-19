using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingAnimator : MonoBehaviour
{
    private Animator playerAnim;
    public bool launched;
    private GameObject player;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");
        playerControllerScript = player.GetComponent<PlayerController>();

        launched = playerControllerScript.launched;


        if (launched)
        {
            playerAnim.SetBool("Flying", true);
        }
        else
        {
            playerAnim.SetBool("Flying", false);
        }
    }
}
