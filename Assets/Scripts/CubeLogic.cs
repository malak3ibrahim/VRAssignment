using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    public bool isPlaced = false;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Rigidbody rb;

    void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    public void MarkPlaced()
    {
        isPlaced = true;
        rb.isKinematic = true;
    }

    public void ResetCube()
    {
        isPlaced = false;
        rb.isKinematic = false;

        transform.position = originalPosition;
        transform.rotation = originalRotation;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
