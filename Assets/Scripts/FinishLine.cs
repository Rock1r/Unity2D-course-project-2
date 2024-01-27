using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _loadDelay = 1f;
    [SerializeField] private string _sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Finish!");
            Invoke("LoadNextScene", _loadDelay);
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }
}
