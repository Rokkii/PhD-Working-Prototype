using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MobileMovement : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;
    InputAction lookAction;
    public Camera playerCamera;
    public float playerSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
        lookAction = playerInput.actions.FindAction("Look");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        Vector2 lookDirection = lookAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * playerSpeed * Time.deltaTime;
        //playerCamera.transform.position += new Vector3(lookDirection.x, 0, lookDirection.y) * playerSpeed * Time.deltaTime;
    }
}
