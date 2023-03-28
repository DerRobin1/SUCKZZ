using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernDeleteOnLoad : MonoBehaviour
{
    public static TavernDeleteOnLoad instance;

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
