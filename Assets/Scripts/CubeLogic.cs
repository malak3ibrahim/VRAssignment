using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    public string cubeColor;
    public Vector3 originalPosition;
    public bool isPlaced = false;
    public Rigidbody rb;

    void Start()
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    public void ResetCube()
    {
        transform.position = originalPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        isPlaced = false;
        // Optional: play buzz sound
        AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("True"), transform.position);
    }

    public void LockCube()
    {
        isPlaced = true;
        rb.isKinematic = true;
    }
}
