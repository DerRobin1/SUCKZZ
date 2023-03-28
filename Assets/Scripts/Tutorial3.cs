using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial3 : MonoBehaviour
{
    public GameObject Tut3;
    public GameObject WASDTaste;
    public GameObject Part4;
    public GameObject Part2;
    public GameObject SpaceTaste;
    bool IsActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Horizontal") && IsActive == false)
        {
            IsActive = true;
            Part2.SetActive(false);
            StartCoroutine(Jump());
        }

    }

    IEnumerator Jump()
    {
        WASDTaste.SetActive(false);
        Tut3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(12);
        SpaceTaste.SetActive(true);
        Tut3.SetActive(false);
        Part4.SetActive(true);
    }
}
