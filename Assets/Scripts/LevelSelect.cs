using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //LoadScene laitetaan osaksi MainMenuta ja main menu kiinnitet��n nappien osaksi, jolloin napin toiminnoksi klikatessa se siirt��
    //alla olevaan funktioon tason nimen 
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
