using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackOutside : MonoBehaviour
{
    public string sceneToLoad;
    public string exitName;
    public GameObject LadeText;
    public GameObject TavernCam;
    public GameObject FadeOut;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Verlassen());
        }
    }

    IEnumerator Verlassen()
    {

        LadeText.SetActive(true);
        FadeOut.SetActive(true);
        FadeOut.GetComponent<Animator>().Play("FadeOut");
        yield return new WaitForSeconds(1);
        PlayerPrefs.SetString("LastExitName", exitName);
        SceneManager.LoadScene(sceneToLoad);
    }
}
