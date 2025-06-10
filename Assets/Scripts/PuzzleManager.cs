// PuzzleManager.cs
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager Instance;

    public CubeLogic[] cubes;
    public GameObject successPanel;
    public AudioClip successSound;

    private void Awake()
    {
        Instance = this;
    }

    public void CheckPuzzle()
    {
        foreach (var cube in cubes)
        {
            if (!cube.isPlaced)
                return;
        }

        ShowSuccess();
    }

    void ShowSuccess()
    {
        if (successPanel != null)
            successPanel.SetActive(true);

        if (successSound != null)
            AudioSource.PlayClipAtPoint(successSound, Camera.main.transform.position);

        Debug.Log("Puzzle Completed!");
    }

    public void RestartPuzzle()
    {
        foreach (var cube in cubes)
        {
            cube.ResetCube();
        }

        if (successPanel != null)
            successPanel.SetActive(false);
    }
}
