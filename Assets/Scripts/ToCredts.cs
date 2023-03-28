using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToCredts : MonoBehaviour
{
    public GameObject Fade;
    public GameObject laden;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(CreditZeitreise());
        }
    }

    IEnumerator CreditZeitreise()
    {
        Fade.SetActive(true);
        laden.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("LaborEndscene");
        laden.SetActive(false);
        Fade.SetActive(false);
    }

}
