using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntoTavern : MonoBehaviour
{
    public GameObject LadeText;
    public GameObject TavernCam;
    public string sceneToLoad;
    public string exitName;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(ReinDa());
        }
    }

    IEnumerator ReinDa()
    {
        TavernCam.SetActive(true);
        LadeText.SetActive(true);

        yield return new WaitForSeconds(2);
        PlayerPrefs.SetString("LastExitName", exitName);
        SceneManager.LoadScene(sceneToLoad);


    }
}
