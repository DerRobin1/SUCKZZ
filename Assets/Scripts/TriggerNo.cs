using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNo : MonoBehaviour
{

    public float theDistance;
    public GameObject Meldung;
    public GameObject actionDisplay;
    public GameObject actionText;

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
                StartCoroutine(Fehler());
            }
        }
    }

    IEnumerator Fehler()
    {
        Meldung.SetActive(true);
        yield return new WaitForSeconds(2);
        Meldung.SetActive(false);
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
