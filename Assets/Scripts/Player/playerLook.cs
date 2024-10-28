using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLook : MonoBehaviour
{
    [SerializeField]
    public Camera Camera;
    [SerializeField]
    private float xSensitivity = 60f;
    [SerializeField]
    private float ySensitivity = 60f;


    private float xRotation = 0f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y; 

        xRotation -= (mouseY *Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        Camera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);

    }
}
