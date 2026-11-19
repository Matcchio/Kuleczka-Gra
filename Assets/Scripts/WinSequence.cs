using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSequence : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.GetComponentInParent<PlayerMovement>() != null)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
