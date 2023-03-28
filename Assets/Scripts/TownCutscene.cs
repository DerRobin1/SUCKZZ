using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownCutscene : MonoBehaviour
{
    public GameObject Kamerafahrt1;
    public GameObject Kamerafahrt2;
    public GameObject Kamerafahrt3;
    public AudioSource Sound;
    public GameObject Spieler;
    public GameObject InfoTextStadt;
    public GameObject InfoTextJahr;
    public GameObject CutsceneObject;
    public GameObject Fade;
    public GameObject Fade2;
    public GameObject Melody;


    void Start()
    {
        StartCoroutine(Cutscene());
    }

    IEnumerator Cutscene()
    {
        Spieler.SetActive(false);
        Melody.SetActive(false);
        Sound.Play();
        Fade2.SetActive(true);
        yield return new WaitForSeconds(1);
        Kamerafahrt1.SetActive(true);
        yield return new WaitForSeconds(3);
        Kamerafahrt1.SetActive(false);
        Kamerafahrt2.SetActive(true);
        yield return new WaitForSeconds(3);
        Kamerafahrt2.SetActive(false);
        Kamerafahrt3.SetActive(true);
        yield return new WaitForSeconds(3);
        InfoTextStadt.SetActive(true);
        InfoTextStadt.GetComponent<Animator>().Play("Stadtanzeige");
        yield return new WaitForSeconds(3);
        InfoTextJahr.SetActive(true);
        InfoTextJahr.GetComponent<Animator>().Play("Stadtanzeige");
        yield return new WaitForSeconds(4);
        InfoTextJahr.GetComponent<Animator>().Play("Stadtwegzeige");
        yield return new WaitForSeconds(1);
        InfoTextStadt.GetComponent<Animator>().Play("Stadtwegzeige");
        yield return new WaitForSeconds(2);
        Fade2.SetActive(false);
        InfoTextJahr.SetActive(false);
        InfoTextStadt.SetActive(false);
        Kamerafahrt3.SetActive(false);
        Fade.SetActive(true);
        Spieler.SetActive(true);
        Melody.SetActive(true);
        CutsceneObject.SetActive(false);
    }
}
