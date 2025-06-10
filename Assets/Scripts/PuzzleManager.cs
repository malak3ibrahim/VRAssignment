// PuzzleManager.cs
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager Instance;

    public CubeLogic[] cubes;
    public GameObject successPanel; // Assign this in the Inspector
    public AudioClip successSound;

    void Awake()
    {
        Instance = this;
    }

    public void CheckPuzzle()
    {
        foreach (CubeLogic cube in cubes)
        {
            if (!cube.isPlaced)
                return;
        }

        ShowSuccess();
    }

    void ShowSuccess()
    {
        if (successPanel != null)
            successPanel.SetActive(true); // Make Canvas appear

        if (successSound != null)
            AudioSource.PlayClipAtPoint(successSound, Camera.main.transform.position);

        Debug.Log("Puzzle Completed!");
    }

    public void RestartPuzzle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
