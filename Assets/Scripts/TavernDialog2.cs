using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernDialog2 : MonoBehaviour
{
    public GameObject Trigger2;
    public AudioSource Dialog2;
    public GameObject KameraDialog;
    public GameObject Spieler;
    public GameObject Sprechblase;
    public GameObject KistenTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Dialog2TavernStart());
        }
    }

    IEnumerator Dialog2TavernStart()
    {
        Sprechblase.SetActive(false);
        Spieler.SetActive(false);
        KameraDialog.SetActive(true);
        Dialog2.Play();
        yield return new WaitForSeconds(5);
        KistenTrigger.SetActive(true);
        KameraDialog.SetActive(false);
        Spieler.SetActive(true);
        Trigger2.GetComponent<BoxCollider>().enabled = false;
    }
}
