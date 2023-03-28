using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernDialog1 : MonoBehaviour
{

    public GameObject Trigger1;
    public AudioSource Dialog1;
    public GameObject KameraKiste;
    public GameObject KameraDialog;
    public GameObject Spieler;
    public GameObject Sprechblase;
    public GameObject Schlüssel;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(DialogTavernStart());
        }
    }

    IEnumerator DialogTavernStart()
    {
        Sprechblase.SetActive(false);
        Spieler.SetActive(false);
        KameraDialog.SetActive(true);
        Dialog1.Play();
        yield return new WaitForSeconds(11);
        KameraDialog.SetActive(false);
        KameraKiste.SetActive(true);
        yield return new WaitForSeconds(4);
        KameraKiste.SetActive(false);
        KameraDialog.SetActive(true);
        yield return new WaitForSeconds(3);
        KameraDialog.SetActive(false);
        Spieler.SetActive(true);
        Schlüssel.SetActive(true);
        Trigger1.GetComponent<BoxCollider>().enabled = false;
    }

}
