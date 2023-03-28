using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial4 : MonoBehaviour
{
    public GameObject Tut4;
    public GameObject Part3;
    public GameObject SpaceTaste;
    public GameObject KnopfEnd;
    public GameObject Hologram;

    bool IsActive = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && IsActive == false)
        {
            IsActive = true;
            Part3.SetActive(false);
            StartCoroutine(Finish());
        }
    }

    IEnumerator Finish()
    {
        SpaceTaste.SetActive(false);
        Part3.SetActive(false);
        Tut4.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(12);
        KnopfEnd.SetActive(true);
        Tut4.SetActive(false);
        Hologram.SetActive(false);

    }
}

