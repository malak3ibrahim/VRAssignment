using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager Instance;

    public CubeLogic[] cubes;
    public GameObject successUI;
    public AudioClip winSound;

    void Awake()
    {
        Instance = this;
    }

    public void CheckCompletion()
    {
        foreach (CubeLogic cube in cubes)
        {
            if (!cube.isPlaced) return;
        }

        PuzzleCompleted();
    }

    void PuzzleCompleted()
    {
        Debug.Log("Puzzle Completed!");
        successUI.SetActive(true);
        AudioSource.PlayClipAtPoint(winSound, Camera.main.transform.position);
    }

    public void RestartPuzzle()
    {
        successUI.SetActive(false);
        foreach (CubeLogic cube in cubes)
        {
            cube.rb.isKinematic = false;
            cube.ResetCube();
        }
    }
}
