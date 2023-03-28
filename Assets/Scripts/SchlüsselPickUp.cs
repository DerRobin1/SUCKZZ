using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchlüsselPickUp : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject Kreuz;
    public GameObject Haken;
    public GameObject Dialog2;
    public GameObject Sprechblase;
    public AudioSource Klink;
    public GameObject Schlüssel;

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 4)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Klink.Play();
                Kreuz.SetActive(false);
                Haken.SetActive(true);
                Dialog2.SetActive(true);
                Sprechblase.SetActive(true);
                Schlüssel.SetActive(false);
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
