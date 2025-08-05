using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float smoothing = 5f;

    Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;
    }

    void Update()
    {
        Vector3 playerCameraPos = player.position + offset;
        transform.position = Vector3.Lerp (transform.position, playerCameraPos, smoothing * Time.deltaTime);
    }
}
