using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 10f;
    private Vector3 movement;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Move(horizontalInput, verticalInput);
    }

    private void Move(float horizontalInput, float verticalInput)
    {
        movement.Set (horizontalInput, 0f, verticalInput);
        movement = movement.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);
    }
}
