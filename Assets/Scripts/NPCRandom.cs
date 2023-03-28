using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandom : MonoBehaviour
{

    public int genPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            genPos = Random.Range(1, 5);

            if (genPos == 5)
            {
                this.gameObject.transform.position = new Vector3(0, 56, 62);
            }
            if (genPos == 4)
            {
                this.gameObject.transform.position = new Vector3(31, 56, 56);
            }
            if (genPos == 3)
            {
                this.gameObject.transform.position = new Vector3(9, 2, 31);
            }
            if (genPos == 2)
            {
                this.gameObject.transform.position = new Vector3(25, 56, 47);
            }
            if (genPos == 1)
            {
                this.gameObject.transform.position = new Vector3(1, 56, 35);
            }
        }
    }



}
