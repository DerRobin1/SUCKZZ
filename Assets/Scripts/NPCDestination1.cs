using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination1 : MonoBehaviour
{
    public int trigNum;
    public GameObject Frau;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {

                if (trigNum == 0)
                {
                    this.gameObject.transform.position = new Vector3(9, 2, 31);
                    trigNum = 1;
                }

                if (trigNum == 1)
                {
                Frau.SetActive(false);
                }

        }
        }
    }
