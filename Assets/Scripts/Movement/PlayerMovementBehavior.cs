using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Vector3 _velocity;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        _velocity = direction * _speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + _velocity);
    }
}
