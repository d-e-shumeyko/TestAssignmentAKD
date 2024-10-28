using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class inputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.WalkingActions walkingActions;
    private PlayerMotor motor;
    private playerLook look;

    void Awake()
    {
        playerInput = new PlayerInput();
        walkingActions = playerInput.walking;

        motor = GetComponent<PlayerMotor>();
        look = GetComponent<playerLook>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnEnable()
    {
        walkingActions.Enable();
    }

    private void OnDisable()
    {
        walkingActions.Disable();
    }

    void FixedUpdate()
    {
        motor.ProcessMove(walkingActions.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.ProcessLook(walkingActions.Look.ReadValue<Vector2>());
    }
}
