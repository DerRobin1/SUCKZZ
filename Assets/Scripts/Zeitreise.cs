using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Zeitreise : MonoBehaviour
{
    public float theDistance;
    public string exitName;
    public GameObject Etaste;
    public GameObject EText;
    public GameObject Knopf;
    public GameObject FadeOut;
    public string sceneToLoad;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 2)
        {
            Etaste.SetActive(true);
            EText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Wusch());
            }
        }

    }

    IEnumerator Wusch()
    {
        Knopf.GetComponent<Animator>().Play("Klick");
        yield return new WaitForSeconds(3);
        FadeOut.SetActive(true);
        FadeOut.GetComponent<Animator>().Play("FadeOut");
        yield return new WaitForSeconds(2);
        PlayerPrefs.SetString("LastExitName", exitName);
        SceneManager.LoadScene(sceneToLoad);
    }

    void OnMouseExit()
    {
        Etaste.SetActive(false);
        EText.SetActive(false);
    }

}
