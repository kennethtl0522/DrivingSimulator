using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Update();
    }


    private float _speed = 20.0f;
    private float _turnSpeed = 45.0f;
    private float _horizontalInput;
    private float _forwardInput;
    
    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * (Time.deltaTime * _speed * _forwardInput));
        transform.Rotate(Vector3.up, _turnSpeed * _horizontalInput * Time.deltaTime);

    }
}
