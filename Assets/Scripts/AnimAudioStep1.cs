using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimAudioStep1 : MonoBehaviour
{
   public AudioSource animationSoundPlayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerSoundStep1()
    {
        animationSoundPlayer.Play();
    }

}
