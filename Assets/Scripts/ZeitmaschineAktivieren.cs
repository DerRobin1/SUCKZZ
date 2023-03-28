using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeitmaschineAktivieren : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject Spieler;
    public GameObject Zeitmaschine;
    public GameObject ZeitmaschineRepair;
    public GameObject Kamera1;
    public GameObject FadeOut;
    public GameObject ExitTrigger;
    public GameObject Trigger;

    // Update is called once per frame
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
                StartCoroutine(Repair());
            }
        }
    }

    IEnumerator Repair()
    {
        Spieler.SetActive(false);
        ZeitmaschineRepair.SetActive(true);
        Zeitmaschine.SetActive(false);
        FadeOut.SetActive(true);
        Kamera1.SetActive(true);
        yield return new WaitForSeconds(4);
        Kamera1.SetActive(false);
        ExitTrigger.SetActive(true);
        Spieler.SetActive(true);
        Trigger.GetComponent<BoxCollider>().enabled = false;
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
