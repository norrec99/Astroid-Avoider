using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float forceMagnitude; 
    [SerializeField] private float maxVelocity; 

    private Camera mainCamera;
    private Rigidbody rb;

    private Vector3 movementDirection;

    void Awake()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Touchscreen.current.primaryTouch.press.isPressed)
        {
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(touchPosition);

            movementDirection = transform.position - worldPosition;
            movementDirection.z = 0f;
            movementDirection.Normalize();

        }
        else
        {
            movementDirection = Vector3.zero;
        }
    }

    private void FixedUpdate() 
    {
        if (movementDirection == Vector3.zero) { return; }

        rb.AddForce(movementDirection * forceMagnitude, ForceMode.Force); 
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);   
    }
}
