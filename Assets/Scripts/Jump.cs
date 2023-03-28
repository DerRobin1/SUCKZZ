using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public AudioSource Jumping;
    public float jspeed = 1;
    public float jumpforce = 5;
    private bool isGrounded;
    public GameObject Player;
    public Animator PlayerAnimator;
    Rigidbody rigid;


    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimator.GetComponent<Animator>();
        Player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Jump") == 1 && isGrounded == true)
        {

            rigid.velocity = Vector3.up * jumpforce;
            Jumping.Play();
            PlayerAnimator.SetBool("IsJumping", true);
            isGrounded = false;


        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
        PlayerAnimator.SetBool("IsJumping", false);
    }
}
