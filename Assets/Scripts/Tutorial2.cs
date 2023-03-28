using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    public GameObject Tut2;
    public GameObject CKnopf;
    public GameObject WASDTaste;
    public GameObject Part3;
    bool IsActive = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && IsActive == false)
        {
            IsActive = true;
            StartCoroutine(Walk());

        }


    }

    IEnumerator Walk()
    {

        CKnopf.SetActive(false);
        Tut2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(17);
        WASDTaste.SetActive(true);
        Part3.SetActive(true);
        Tut2.SetActive(false);

    }
}
