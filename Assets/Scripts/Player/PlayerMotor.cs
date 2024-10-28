using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    private CharacterController controler;
    private Vector3 playerVel;
    [SerializeField]
     float speed = 20f;
    [SerializeField]
    private float gravity = -9.8f;
    private bool isGrounded;



    void Start()
    {
        controler = GetComponent<CharacterController>();
    }

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = input.x;
        moveDir.z = input.y;
        controler.Move(transform.TransformDirection(moveDir) * speed * Time.deltaTime);
        playerVel.y += gravity * Time.deltaTime;
        if (isGrounded && playerVel.y < 0)
        {
            playerVel.y = -2;
        }
        controler.Move(playerVel * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controler.isGrounded;
    }
}
