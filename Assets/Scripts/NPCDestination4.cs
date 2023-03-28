using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination4 : MonoBehaviour
{
    public int trigNum;
    public GameObject Deer;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            trigNum = 1;
        }

        if (trigNum == 1)
        {
          Deer.SetActive(false);
        }

        }
        }
    
