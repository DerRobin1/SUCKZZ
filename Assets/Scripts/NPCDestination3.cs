using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination3 : MonoBehaviour
{
    public int trigNum;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {

                if (trigNum == 0)
                {
                    this.gameObject.transform.position = new Vector3(0,56, 62);
                    trigNum = 1;
                }

                if (trigNum == 1)
                {
                    this.gameObject.transform.position = new Vector3(31, 56, 56);
                    trigNum = 0;
                }

        }
        }
    }
