using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Movements : MonoBehaviour
{
    private Rigidbody body;
    [SerializeField] private float _speed;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            body.AddForce(0f, 0f, 1f * _speed);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            body.AddForce(0f, 0f, -1f * _speed);
        }
        else if(Input.GetKey(KeyCode.D ))
        {
            body.AddForce(1* _speed, 0f, 0f );
        }
        else if(Input.GetKey(KeyCode.A))
        {
            body.AddForce(-1* _speed, 0f, 0f );
        }
        
    }
}
