using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernKiste : MonoBehaviour
{

    public float theDistance;
    public GameObject KisteAnim;
    public GameObject Kristall;
    public GameObject Kamera1;
    public GameObject Spieler;
    public GameObject actionDisplay;
    public GameObject actionText;

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
                StartCoroutine(Kiste());
            }
        }
    }

    IEnumerator Kiste()
    {
        Spieler.SetActive(false);
        yield return new WaitForSeconds(1);
        Spieler.SetActive(true);
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
