using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneBeginn : MonoBehaviour
{

    public GameObject Spieler;
    public GameObject AutoCam;
    public GameObject LetterCam;
    public GameObject Fade;
    public GameObject BlackScreen;
    public GameObject FensterCam;
    public AudioSource Brake;
    public AudioSource Ringbell;
    public AudioSource Brief;
    public AudioSource Brief2;
    public GameObject BigLetter;
    public AudioSource Door;
    public GameObject Laden;
    public GameObject Auto;
    public GameObject FadeWhite;
    public GameObject EButton;
    public AudioSource AutoMotor;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(BeginningCut());
    }

    IEnumerator BeginningCut()
    {
        FadeWhite.SetActive(true);
        yield return new WaitForSeconds(1);
        AutoMotor.Play();
        Auto.GetComponent<Animator>().Play("PostAuto");
        yield return new WaitForSeconds(2);
        Brake.Play();
        yield return new WaitForSeconds(2);
        Door.Play();
        yield return new WaitForSeconds(1);
        AutoCam.SetActive(false);
        FensterCam.SetActive(true);
        yield return new WaitForSeconds(3);
        BlackScreen.SetActive(true);
        Ringbell.Play();
        yield return new WaitForSeconds(2);
        BlackScreen.SetActive(false);
        Spieler.SetActive(true);
        yield return new WaitForSeconds(3);
        Spieler.SetActive(false);
        LetterCam.SetActive(true);
        yield return new WaitForSeconds(3);
        Brief.Play();
        BigLetter.SetActive(true);
        EButton.SetActive(true);
    }

    void Update()
    {
        if (BigLetter.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(BriefLesen());
        }
    }

    IEnumerator BriefLesen()
    {
        BigLetter.SetActive(false);
        EButton.SetActive(false);
        Brief2.Play();
        Fade.SetActive(true);
        Laden.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Labor");
    }

}
