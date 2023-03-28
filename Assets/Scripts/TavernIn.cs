using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TavernIn : MonoBehaviour
{
    public GameObject TextFeld;
    public GameObject Trigger;
    public GameObject Player;
    public GameObject TavernCam;

    void OnTriggerEnter()
    {
        TextFeld.SetActive(true);
        Player.SetActive(false);
        TavernCam.SetActive(true);
    }

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("Tavern");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            StartCoroutine(TriggerWeg());
        }

    }


    IEnumerator TriggerWeg()
    {
        TextFeld.SetActive(false); 
        Trigger.GetComponent<BoxCollider>().enabled = false;
        Player.SetActive(true);
        TavernCam.SetActive(false);


        yield return new WaitForSeconds(3);

        Trigger.GetComponent<BoxCollider>().enabled = true;
    }

}
