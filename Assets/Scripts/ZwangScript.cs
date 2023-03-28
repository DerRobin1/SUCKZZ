using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZwangScript : MonoBehaviour
{
    public GameObject Text;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Text.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
        Text.SetActive(false);
    }
}
