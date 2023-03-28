using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KindTrigger2 : MonoBehaviour
{

    public GameObject Trigger2;
    public GameObject Trigger3;
    public GameObject Pfeil;
    public GameObject Pfeil2;
    public GameObject Kind2;
    public GameObject Kind1;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Kind1.SetActive(false);
            Kind2.SetActive(true);
            Pfeil.SetActive(false);
            Trigger3.SetActive(true);
            Trigger2.SetActive(false);
            Pfeil2.SetActive(true);

        }
    }
}
