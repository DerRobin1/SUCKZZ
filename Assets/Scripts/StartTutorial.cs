using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTutorial : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject Knopfall;
    public GameObject Hologram;
    public AudioSource Tut1;
    public GameObject CKnopf;
    public GameObject Part2;
    public AudioSource Knopfweg;



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
                StartCoroutine(KnopfDruck());
            }
        }

    }

    IEnumerator KnopfDruck()
    {
        Knopfall.GetComponent<Animator>().Play("StartKnopf");
        Knopfweg.Play();
        yield return new WaitForSeconds(2);
        Hologram.SetActive(true);
        Tut1.Play();
        yield return new WaitForSeconds(41);
        CKnopf.SetActive(true);
        Part2.SetActive(true);
    }


    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}