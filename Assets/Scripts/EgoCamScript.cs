using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EgoCamScript : MonoBehaviour
{
    private float pitch = 0.0f;
    public float mouseSensitivity = 2f;
    public float maxLookAngle = 50f;
    public float fov = 60f;
    public Camera playerCamera;
    private float yaw = 0.0f;
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        if (!Pause.IsPaused)
        {
            yaw = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity;

            pitch -= mouseSensitivity * Input.GetAxis("Mouse Y");

            pitch = Mathf.Clamp(pitch, -maxLookAngle, maxLookAngle);

            transform.localEulerAngles = new Vector3(0, yaw, 0);
            playerCamera.transform.localEulerAngles = new Vector3(pitch, 0, 0);


            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}

