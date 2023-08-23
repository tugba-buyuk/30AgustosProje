using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class OyunKontrol : MonoBehaviour
{
    public Text zaman, can;
    float zamanSayaci = 300;
    float canSayaci = 5;
    bool oyunDevam = true;
   
   
   
   

    private void OnCollisionEnter(Collision coll)
    {
        string objTag = coll.gameObject.tag;
        if (objTag.Equals("yardimussu"))
        {
            SceneManager.LoadScene("win");



        }
        else if (objTag.Equals("Enemy"))
        {
            canSayaci -= 1;
            can.text = canSayaci + "";
            if (canSayaci <= 0)
            {
                oyunDevam = false;
                SceneManager.LoadScene("end");
            }
        }
    }


    private void Update()
    {
        zamanSayaci -= Time.deltaTime;
        zaman.text = (int)zamanSayaci + "";
        if (zamanSayaci <= 0)
        {
            oyunDevam = false;
            SceneManager.LoadScene("end");
        }
    }


}
