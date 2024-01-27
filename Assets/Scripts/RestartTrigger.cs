using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "World")
        {
            Debug.Log("This is the end");
            SceneManager.LoadScene("Level1");
        }
    }
}
