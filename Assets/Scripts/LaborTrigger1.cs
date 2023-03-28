using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaborTrigger1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Prof;
    public GameObject Kamera1;
    public GameObject Kamera2;
    public GameObject Kamera3;
    public GameObject Sprechblase;
    public GameObject Trigger1;
    public GameObject Trigger2;
    public AudioSource Dia1;
    public AudioSource Dia2;
    public AudioSource Dia3;
    public AudioSource Dia4;
    public AudioSource Dia5;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Los());
        }
    }

    IEnumerator Los()
    {
        Sprechblase.SetActive(false);
        Player.SetActive(false);
        Kamera1.SetActive(true);
        Dia1.Play();
        Prof.GetComponent<Animator>().Play("CharacterArmature_Idle_Neutral 1");
        yield return new WaitForSeconds(9);
        Prof.GetComponent<Animator>().Play("CharacterArmature_Gun_Shoot");
        yield return new WaitForSeconds(3);
        Kamera1.SetActive(false);
        Kamera3.SetActive(true);
        Prof.GetComponent<Animator>().Play("CharacterArmature_Idle_Neutral 1");
        Dia2.Play();
        yield return new WaitForSeconds(6);
        Kamera1.SetActive(true);
        Kamera3.SetActive(false);
        yield return new WaitForSeconds(3);
        Dia3.Play();
        yield return new WaitForSeconds(7);
        Dia4.Play();
        Prof.GetComponent<Animator>().Play("CharacterArmature_Gun_Shoot");
        Kamera1.SetActive(false);
        Kamera2.SetActive(true);
        Kamera2.GetComponent<Animator>().Play("Parkur");
        yield return new WaitForSeconds(4);
        Dia5.Play();
        Kamera2.SetActive(false);
        Kamera1.SetActive(true);
        Prof.GetComponent<Animator>().Play("CharacterArmature_Idle_Neutral 1");
        yield return new WaitForSeconds(3);
        Kamera1.SetActive(false);
        Trigger1.GetComponent<BoxCollider>().enabled = false;
        Player.SetActive(true);
        Trigger2.SetActive(true);
    }

}
