using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEntrance : MonoBehaviour
{
    public string lastExitName;
    public GameObject FadeInScreen;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("LastExitName") == lastExitName)
        {
            FadeInScreen.SetActive(true);
            PlayerDestroy.instance.transform.position = transform.position;
            PlayerDestroy.instance.transform.eulerAngles = transform.eulerAngles;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
