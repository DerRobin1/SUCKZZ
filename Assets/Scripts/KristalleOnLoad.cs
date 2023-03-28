using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KristalleOnLoad : MonoBehaviour
{
    public static KristalleOnLoad instance;

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
