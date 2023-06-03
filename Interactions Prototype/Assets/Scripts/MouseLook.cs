using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 150f;
    [SerializeField] Transform player;
    float xRotation = 0f;
    
    void Start()
    {
        CursorSetting();    
    }    

    
    void Update()
    {
        CameraInputAndRotation();        
    }  

    void CursorSetting()
    {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    }

     void CameraInputAndRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
    
    
        

    
}
