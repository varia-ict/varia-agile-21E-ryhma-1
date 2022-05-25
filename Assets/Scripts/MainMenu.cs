using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame()
    {
        //t‰m‰ funktio lis‰‰ aktiivisen kohtauksen indeksiin yhden ja next level/start game nappi toimii silloin
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
