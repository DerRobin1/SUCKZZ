using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KindTrigger3 : MonoBehaviour
{
    public GameObject SpielerCam1;
    public GameObject Kamera1;
    public GameObject Trigger3;
    public GameObject Trigger4;
    public GameObject Sprechblase;
    public GameObject Pfeil2;
    public GameObject Kind2;
    public GameObject Kind1;

    void OnTriggerEnter(Collider other)
    {
        Kind2.SetActive(false);
        Kind1.SetActive(true);
        Sprechblase.SetActive(true);
        Kamera1.SetActive(false);
        SpielerCam1.SetActive(true);
        Trigger4.SetActive(true);
        Trigger3.SetActive(false);
        Pfeil2.SetActive(false);
    }
}
