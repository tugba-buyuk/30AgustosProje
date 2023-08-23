using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    public float can = 100;
    private Animator anime;
    public bool öldümü = false;

    private void Start()
    {
        anime = GetComponent<Animator>();
    }

    public void HasarVer (float amount)
    {
        can -= amount;

        if(can <= 0)
        {
            ölüm();
        }
    }

    public void ölüm ()
    {
        anime.SetBool("Öldü", true);
        öldümü = true;
        gameObject.tag = "Untagged";

        StartCoroutine(sil());

    }
    IEnumerator sil()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
