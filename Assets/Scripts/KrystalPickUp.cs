using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KrystalPickUp : MonoBehaviour
{
    public AudioSource Einsammel;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GlobalKristalCount.CurrentKry += 1;
            Einsammel.Play();
            this.gameObject.GetComponent<ParticleSystem>().Play();
            this.gameObject.SetActive(false);
        }
    }
}
