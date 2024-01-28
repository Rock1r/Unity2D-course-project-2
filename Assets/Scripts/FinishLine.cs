using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float _loadDelay = 0.5f;
    [SerializeField] private string _sceneToLoad;
    [SerializeField] private ParticleSystem _finishEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("LoadNextScene", _loadDelay);
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(_sceneToLoad);
    }

}
