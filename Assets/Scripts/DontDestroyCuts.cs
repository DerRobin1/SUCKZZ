using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyCuts : MonoBehaviour
{
    public static DontDestroyCuts instance;

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
