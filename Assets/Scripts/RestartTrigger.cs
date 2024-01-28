using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{
    [SerializeField] private float _loadDelay = 1f;
    [SerializeField] private AudioClip _crashSound;

    private bool _hasCrashed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "World" && !_hasCrashed)
        {
            _hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            GetComponent<AudioSource>().PlayOneShot(_crashSound);
            Invoke("LoadNextScene", _loadDelay);
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(0);
    }
}
