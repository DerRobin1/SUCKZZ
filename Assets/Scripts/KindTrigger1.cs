using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KindTrigger1 : MonoBehaviour
{
    public GameObject DialogKamera;
    public GameObject KameraZeigen;
    public GameObject Spieler;
    public AudioSource KindSprich1;
    public GameObject Trigger1;
    public GameObject Trigger2;
    public GameObject Sprechblase;
    public GameObject Pfeil;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Kind1());
        }
    }

    IEnumerator Kind1()
    {
        Pfeil.SetActive(true);
        Sprechblase.SetActive(false);
        Spieler.SetActive(false);
        DialogKamera.SetActive(true);
        KindSprich1.Play();
        yield return new WaitForSeconds(15);
        DialogKamera.SetActive(false);
        KameraZeigen.SetActive(true);
        yield return new WaitForSeconds(4);
        KameraZeigen.SetActive(false);
        DialogKamera.SetActive(true);
        yield return new WaitForSeconds(1);
        DialogKamera.SetActive(false);
        Spieler.SetActive(true);
        Trigger2.SetActive(true);
        Trigger1.SetActive(false);

    }
}
