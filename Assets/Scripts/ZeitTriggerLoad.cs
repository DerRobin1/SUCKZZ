using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeitTriggerLoad : MonoBehaviour
{

    public static ZeitTriggerLoad instance;

    void Start()
    {
        DontDestroyOnLoad(gameObject);


        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
}
