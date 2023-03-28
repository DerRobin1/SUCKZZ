using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialLeave : MonoBehaviour
{

    public GameObject Whitescreen;

    void OnTriggerEnter()
    {
        Whitescreen.SetActive(true);
        SceneManager.LoadScene("IntroCutscene");
    }
}
