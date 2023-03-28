using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour
{
    public string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(Splash());
    }

    IEnumerator Splash()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(sceneToLoad);
    }
}
