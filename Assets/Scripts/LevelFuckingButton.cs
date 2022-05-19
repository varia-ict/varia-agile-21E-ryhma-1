using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using UnityEngine.SceneManagement;

public class LevelFuckingButton : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
   // public void eka(string Level1)
     //   {
       //     SceneManager.LoadScene(Level1);
    //    }
//public void toka(string Level2)
//   {
// SceneManager.LoadScene(Level2);
//}
//public void kolmas(string Level3)
//{
//  SceneManager.LoadScene(Level3);
//}
//public void neljas(string Level4)
//{
//  SceneManager.LoadScene(Level4);
//}

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

   
