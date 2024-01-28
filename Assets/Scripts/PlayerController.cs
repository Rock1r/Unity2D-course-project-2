using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private string horizontal = "Horizontal";

    [SerializeField] private float _torque = 1f;
    [SerializeField] private float _boostSpeed;

    private bool _canMove = true;
    private float _startSpeed;

    private Rigidbody2D _rb;
    private SurfaceEffector2D _effector;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _effector = FindObjectOfType<SurfaceEffector2D>();
        _startSpeed = _effector.speed;
    }

    void Update()
    {
        if (_canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (_effector.speed < _boostSpeed)
            {
            _effector.speed = _boostSpeed;
            }
        }
        else
        {
            if (_effector.speed > _boostSpeed)
            {
            }
            else
            {
            _effector.speed = _startSpeed;
            }
        }
    }

    public void DisableControls()
    {
        _canMove = false;
    }

    private void RotatePlayer()
    {
        float inputHorizontal = Input.GetAxis(horizontal) * _torque * Time.deltaTime;

        if (inputHorizontal < 0f)
        {
            _rb.AddTorque(_torque * Time.deltaTime);
        }
        else if (inputHorizontal > 0f)
        {
                _rb.AddTorque(-_torque * Time.deltaTime);
        }
    }
}