using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsEnd : MonoBehaviour
{
    public GameObject Theme;
    public GameObject Charakter1;
    public GameObject Charakter2;
    public GameObject Fade;
    public GameObject Credits;
    public GameObject Kameraprof;
    public GameObject KameraSchwenk;
    public GameObject Prof;
    public AudioSource Dialog;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(Ende());
    }

    IEnumerator Ende()
    {
        Dialog.Play();
        yield return new WaitForSeconds(1);
        Prof.GetComponent<Animator>().Play("CharacterArmature_Idle_Neutral 1");
        yield return new WaitForSeconds(15);
        Theme.SetActive(true);
        yield return new WaitForSeconds(2);
        Kameraprof.SetActive(false);
        Charakter1.SetActive(true);
        yield return new WaitForSeconds(4);
        Charakter1.SetActive(false);
        Charakter2.SetActive(true);
        KameraSchwenk.SetActive(true);
        yield return new WaitForSeconds(5);
        Fade.SetActive(true);
        Fade.GetComponent<Animator>().Play("FadeToBlack");
        yield return new WaitForSeconds(4);
        Charakter2.SetActive(false);
        Fade.SetActive(false);
        Credits.SetActive(true);
        yield return new WaitForSeconds(28);
        Fade.SetActive(true);
        Fade.GetComponent<Animator>().Play("FadeToBlack");
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("MainMenu");
    }
}


