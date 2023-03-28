using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KindTrigger4 : MonoBehaviour
{
    public GameObject DialogKamera;
    public GameObject Spieler;
    public AudioSource KindSprich2;
    public GameObject Trigger4;
    public GameObject Sprechblase;
    public GameObject Kristall;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Kind2());
        }
    }

    IEnumerator Kind2()
    {
        Sprechblase.SetActive(false);
        Spieler.SetActive(false);
        DialogKamera.SetActive(true);
        KindSprich2.Play();
        yield return new WaitForSeconds(5);
        Kristall.SetActive(true);
        yield return new WaitForSeconds(1);
        DialogKamera.SetActive(false);
        Spieler.SetActive(true);
        Trigger4.SetActive(false);

    }
}
