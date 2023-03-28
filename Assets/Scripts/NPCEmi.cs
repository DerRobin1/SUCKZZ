using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCEmi : MonoBehaviour
{
    public float theDistance;
    public GameObject Sprechblase;
    public GameObject actionDisplay;
    public GameObject actionText;
    public AudioSource WasWirdGesagt;
    public GameObject Trigger;
    public GameObject Spieler;
    public GameObject Kamera1;


    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 2)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Emilia());
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

    IEnumerator Emilia()
    {
        Sprechblase.SetActive(false);
        Trigger.GetComponent<BoxCollider>().enabled = false;
        WasWirdGesagt.Play();
        yield return new WaitForSeconds(14);
        Spieler.SetActive(false);
        Kamera1.SetActive(true);
        yield return new WaitForSeconds(5);
        Spieler.SetActive(true);
        Kamera1.SetActive(false);
        Trigger.GetComponent<BoxCollider>().enabled = true;
    }
}
