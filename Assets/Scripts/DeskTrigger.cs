using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskTrigger : MonoBehaviour
{
    public string expectedColor;

    private void OnTriggerEnter(Collider other)
    {
        CubeLogic cube = other.GetComponent<CubeLogic>();
        if (cube != null && !cube.isPlaced)
        {
            if (cube.cubeColor == expectedColor)
            {
                cube.transform.position = transform.position;
                cube.LockCube();
                PuzzleManager.Instance.CheckCompletion();
                // Optional: success sound
                AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("True"), transform.position);
            }
            else
            {
                cube.ResetCube();
            }
        }
    }
}