using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KisteTriggerScript : MonoBehaviour
{
    public float theDistance;
    public GameObject Kiste;
    public GameObject Kristall;
    public GameObject Trigger;
    public GameObject actionText;
    public GameObject actionDisplay;
    public AudioSource Klappeauf;


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
                StartCoroutine(KisteAufmachen());
            }
        }
    }

    IEnumerator KisteAufmachen()
    {
        Kiste.GetComponent<Animator>().Play("KisteAuf");
        Klappeauf.Play();
        yield return new WaitForSeconds(2);
        Kristall.SetActive(true);
        Trigger.GetComponent<BoxCollider>().enabled = false;
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
