using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSwitch : MonoBehaviour
{
    public GameObject ThirdPersonC;
    public GameObject EgoCam;
    public int Cammode;
    public GameObject Player;
    public GameObject Crosshair;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("CameraSwitch"))
        {
            if (Cammode == 1)
            {
                Cammode = 0;
            }
            else
            {
                Cammode += 1;
            }

            StartCoroutine(CamSwitch());

        }

    }

    IEnumerator CamSwitch ()
    {
        yield return new WaitForSeconds(0.01f);
        if (Cammode == 0)
        {
            ThirdPersonC.SetActive(false);
            EgoCam.SetActive(true);
            Player.SetActive(false);
            Crosshair.SetActive(true);
        }
        if (Cammode == 1)
        {
            ThirdPersonC.SetActive(true);
            EgoCam.SetActive(false);
            Player.SetActive(true);
            Crosshair.SetActive(false);
        }

    }
}
