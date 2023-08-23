using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cikisYeniden : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
        else if (Input.GetKey(KeyCode.N))
        {
            SceneManager.LoadScene("game");
        }
    }
}
