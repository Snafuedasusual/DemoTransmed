using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float _ghostSpeed;

    [SerializeField]
    private float _ghostRotateSpeed;

    private Rigidbody2D _rigidbody;
    private PlayerAwarenessController _playerAwarenessController;
    private Vector2 _targetDirection;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _playerAwarenessController = GetComponent<PlayerAwarenessController>();

    }
    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateToTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection()
    {
        if (_playerAwarenessController.PlayerAwareness)
        {
            _targetDirection = _playerAwarenessController.DirectionPlayer;
        }
        else
        {
            _targetDirection = Vector2.zero;
        }
    }

    private void RotateToTarget()
    {
        if (_targetDirection == Vector2.zero)
        {
            return;
        }
        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, _targetDirection);
        Quaternion rotateTo = Quaternion.RotateTowards(transform.rotation, targetRotation, _ghostRotateSpeed * Time.deltaTime);
        _rigidbody.SetRotation(rotateTo);
    }

    private void SetVelocity()
    {
        if (_targetDirection == Vector2.zero)
        {
            _rigidbody.velocity = Vector2.zero;
        }
        else
        {
            _rigidbody.velocity = transform.up * _ghostSpeed;
        }
    }
}
