using UnityEngine;

public class Player : MonoBehaviour
{
    public void ChangeGravity(float change)
    {
        GetComponent<Rigidbody2D>().gravityScale = change;
    }
}
