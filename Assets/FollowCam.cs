using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public float speed = 1.5f;
    float RotateX = 0f;
    float RotateY = 0f;
    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X");
        float mousey = Input.GetAxis("Mouse Y");
        RotateX -= mousey*speed;
        RotateY += mousex*speed;
        transform.localRotation = Quaternion.Euler(RotateX, RotateY, 0f);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move);
    }
}
