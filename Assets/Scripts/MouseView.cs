using System.Security.AccessControl;
using System.Reflection;
using System.Collections.Specialized;
using System.Numerics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseView : MonoBehaviour
{
    public float Sensitivity = 0.1f;
    public Transform player1;
    float xRotation = 0f;
    float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity;
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity;

        xRotation -= mouseY;
        yRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 75f);
        transform.localRotation = UnityEngine.Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
