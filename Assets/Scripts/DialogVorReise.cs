using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogVorReise : MonoBehaviour
{
    public GameObject Player;
    public GameObject Prof;
    public GameObject Kamera1;
    public GameObject Kamera2;
    public GameObject Sprechblase;
    public GameObject Trigger2;
    public GameObject Trigger3;
    public GameObject Knopf;
    public GameObject Pfeile;
    public GameObject MussDrücken;
    public AudioSource Los1;
    public AudioSource Los2;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Reden());
        }
    }

    IEnumerator Reden()
    {
        Sprechblase.SetActive(false);
        Player.SetActive(false);
        Kamera1.SetActive(true);
        Los1.Play();
        Prof.GetComponent<Animator>().Play("CharacterArmature_Gun_Shoot");
        yield return new WaitForSeconds(4);
        Knopf.SetActive(true);
        Pfeile.SetActive(true);
        Kamera2.SetActive(true);
        Los2.Play();
        yield return new WaitForSeconds(6);
        Kamera2.SetActive(false);
        Kamera1.SetActive(true);
        Prof.GetComponent<Animator>().Play("CharacterArmature_Idle_Neutral 1");
        yield return new WaitForSeconds(5);
        Kamera1.SetActive(false);
        Trigger2.GetComponent<BoxCollider>().enabled = false;
        Trigger3.SetActive(true);
        MussDrücken.SetActive(true);
        Player.SetActive(true);
    }
}
