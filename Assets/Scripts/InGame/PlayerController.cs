using System;
using R3;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 8.0f;
    
    private float _axis;
    private float _horizon;
    private Rigidbody2D _playerRb;

    void Awake()
    {
        _playerRb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _axis = Input.GetAxis("Horizontal");
        _horizon = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _playerRb.linearVelocity = new Vector2(_axis * _moveSpeed, _horizon * _moveSpeed);
    }
    
}
