using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    public AudioSource Klick;
    public GameObject Laden;
    public GameObject Fade;

    public void Start()
    {
        StartCoroutine(FadeWeg());
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    IEnumerator FadeWeg()
    {
        yield return new WaitForSeconds(2);
        Fade.SetActive(false);
    }

    public void StartGame()
    {
        Laden.SetActive(true);
        Klick.Play();
        SceneManager.LoadScene("Tutorial");
    }

    public void QuitGame()
    {
        Klick.Play();
        Application.Quit();
    }
}
