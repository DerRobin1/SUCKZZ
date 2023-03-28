using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WooshScript : MonoBehaviour
{
    public string sceneToLoad;
    public GameObject Fade;
    public GameObject Speak;
    public GameObject Laden;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(Zeitreise());
    }

    IEnumerator Zeitreise()
    {
        yield return new WaitForSeconds(2);
        Speak.SetActive(true);
        yield return new WaitForSeconds(26);
        Fade.SetActive(true);
        yield return new WaitForSeconds(3);
        Laden.SetActive(true);
        yield return new WaitForSeconds(4);

        SceneManager.LoadScene(sceneToLoad);
    }
}
