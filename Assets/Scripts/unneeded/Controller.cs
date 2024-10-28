using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    CharacterController characterController;
    [SerializeField]
    float speed = 12f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");


        Vector3 move = transform.right * horz + transform.forward * vert;
        characterController.Move(move * speed * Time.deltaTime);

    }
}
