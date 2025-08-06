using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 10f;
    private Vector3 movement;
    private Rigidbody rb;
    public float rotationSpeed = 5.0f;
    public string cameraRotateAxis;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Move(horizontalInput, verticalInput);
        RotateCamera();
    }

    private void Move(float horizontalInput, float verticalInput)
    {
        movement.Set(horizontalInput, 0f, verticalInput);
        movement = movement.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }

    private void RotateCamera()
    {
        float rotationInput = Input.GetAxis(cameraRotateAxis);
        transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);
    }
}
