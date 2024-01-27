using UnityEngine;

public class BoostTrigger : MonoBehaviour
{
    [SerializeField] private float _boostAmount = 1.0f;
    [SerializeField] private World _world;
    [SerializeField] private VirtualCamera _camera;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _world.SetSurfaceSpeed(_boostAmount);
        _camera.ResetCamera();
    }
}
