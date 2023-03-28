using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StromAn : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject ZeitmaschineAus;
    public GameObject ZeitmaschineAn;
    public GameObject Spieler;
    public GameObject Kamera1;
    public GameObject Kamera2;
    public GameObject Kamera3;
    public GameObject Hebel;
    public GameObject FadeIn;
    public GameObject NewTrigger;
    public GameObject Prof;
    public GameObject Sprechblase;
    public GameObject Trigger;
    public AudioSource Klick;
    public AudioSource Strom;
    public AudioSource Zeitmaschine;
    public GameObject Zeitfertigsound;



    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 1)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Hebelrunter());
            }
        }
    }

    IEnumerator Hebelrunter()
    {
        Hebel.GetComponent<Animator>().Play("Hebel");
        Klick.Play();
        yield return new WaitForSeconds(1);
        Spieler.SetActive(false);
        Kamera1.SetActive(true);
        Strom.Play();
        Kamera1.GetComponent<Animator>().Play("StromKamera1");
        yield return new WaitForSeconds(3);
        Kamera1.SetActive(false);
        Kamera2.SetActive(true);
        Strom.Play();
        Kamera2.GetComponent<Animator>().Play("StromKamera2");
        yield return new WaitForSeconds(3);
        Kamera2.SetActive(false);
        Kamera3.SetActive(true);
        FadeIn.SetActive(true);
        FadeIn.GetComponent<Animator>().Play("FadeInAnimation");
        ZeitmaschineAus.SetActive(false);
        ZeitmaschineAn.SetActive(true);
        Zeitmaschine.Play();
        yield return new WaitForSeconds(4);
        Zeitmaschine.Stop();
        Zeitfertigsound.SetActive(true);
        Kamera3.SetActive(false);
        Spieler.SetActive(true);
        NewTrigger.SetActive(true);
        Sprechblase.SetActive(true);
        Prof.GetComponent<Animator>().Play("CharacterArmature_Wave 1");
        Trigger.GetComponent<BoxCollider>().enabled = false;
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
