// CubeLogic.cs
using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    public bool isPlaced = false;
    public Vector3 originalPosition;
    public Rigidbody rb;

    void Start()
    {
        originalPosition = transform.position;
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
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
