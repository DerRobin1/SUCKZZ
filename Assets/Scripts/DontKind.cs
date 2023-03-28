using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontKind : MonoBehaviour
{
    public static DontKind instance;

    // Start is called before the first frame update
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
