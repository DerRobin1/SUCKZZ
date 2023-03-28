using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{
    public GameObject thePlayer;
    public bool isRunning;
    public bool isSprinting;
    public float horizontalMove;
    public float verticalMove;
    public float jspeed = 1;
    public float jumpforce = 5;
    Rigidbody rigid;
    private bool isGrounded;
    public Animator PlayerAnimator;
    public AudioSource Jump;



    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rigid = GetComponent<Rigidbody>();
        PlayerAnimator.GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 2;
            transform.Rotate(0, horizontalMove, 0);
            transform.Translate(0, 0, verticalMove);
            PlayerAnimator.SetFloat("Speed", 0.7f);


        }

        else
        {

            PlayerAnimator.SetFloat("Speed", 0.1f);


        }

        if (Input.GetAxisRaw("Jump") == 1 && isGrounded == true)
        {
          rigid.velocity = Vector3.up * jumpforce;
            Jump.Play();
            PlayerAnimator.SetBool("IsJumping", true);
            isGrounded = false;


        }


        if (Input.GetButton("Vertical") && Input.GetButton("Sprint"))
        {

            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 4;
            transform.Rotate(0, horizontalMove, 0);
            transform.Translate(0, 0, verticalMove);
            PlayerAnimator.SetFloat("Speed", 2f);
        }

    }

    private void OnCollisionStay(Collision collision)
    {
            isGrounded = true;
            PlayerAnimator.SetBool("IsJumping", false);
        
    }

    //private void OnCollisionExit(Collision collision)
    //{
      //  OnCollision = false;
    //}
}
