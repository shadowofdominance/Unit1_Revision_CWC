using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    private float _vehicleSpeed = 30f;
    private float _turnSpeed = 30f;

    [SerializeField] private InputActionAsset inputActionAsset;
    
    private InputAction _moveAction;
    private Vector2 _moveAmount;

    private void OnEnable()
    {
        inputActionAsset.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        inputActionAsset.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        _moveAction = InputSystem.actions.FindAction("Move");
        
    }

    void Update()
    {
        Vector2 moveInput = _moveAction.ReadValue<Vector2>();
        
        float horizontal = moveInput.x;
        float vertical = moveInput.y;
        
        transform.Translate(Vector3.forward * (Time.deltaTime * vertical * _vehicleSpeed));
        transform.Rotate(Vector3.up * (Time.deltaTime * _turnSpeed * horizontal));
    }
}
