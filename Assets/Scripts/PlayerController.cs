using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _torque = 1f;

    private string horizontal = "Horizontal";
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rb != null)
        {
            float inputHorizontal = Input.GetAxis(horizontal) * _torque * Time.deltaTime;
            if (inputHorizontal < 0f)
            {
            _rb.AddTorque(_torque);
            }
            else if (inputHorizontal > 0f)
            {
                _rb.AddTorque(-_torque);
            }
        }
    }
}
