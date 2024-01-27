using UnityEngine;

public class World : MonoBehaviour
{
    public void SetSurfaceSpeed(float boost)
    {
        GetComponent<SurfaceEffector2D>().speed = boost;
    }
}
