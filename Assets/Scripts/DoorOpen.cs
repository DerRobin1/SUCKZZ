using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject leftDoor;
    public GameObject rightDoor;
    public GameObject Knopf;
    public AudioSource Knopfweg;
    public AudioSource DoorSound;

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
                StartCoroutine(KnopfUndWeg());
            }
        }

    }

    IEnumerator KnopfUndWeg()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
        Knopfweg.Play();
        Knopf.GetComponent<Animator>().Play("TutBeenden");
        yield return new WaitForSeconds(2);
        DoorSound.Play();
        leftDoor.GetComponent<Animator>().Play("TutTürLinks");
        rightDoor.GetComponent<Animator>().Play("TutTürRechts");
        

    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}