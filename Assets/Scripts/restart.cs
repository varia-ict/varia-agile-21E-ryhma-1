using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetScene()
    //valitun napin valikosta l�ytyy on-click-valikko johon valitsette t�m�n funktion eli 'ResetScene'
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
