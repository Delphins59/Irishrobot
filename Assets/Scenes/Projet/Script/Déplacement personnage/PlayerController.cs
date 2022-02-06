using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMotor))]


public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    [SerializeField]
    private float lookSensitivity = 3f;

    private PlayerMotor motor;

    [SerializeField]
    private float JumpForce = 1f;
    Vector3 velocity;
    Rigidbody _rigidbody;

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
       _rigidbody = GetComponent<Rigidbody>();

        Physics.gravity = new Vector3(0,-1.0f,0);

    }

    private void Update()
    {
        // calcul vélocité du movement avec vecteur 3D
        float _xMov = Input.GetAxisRaw("Horizontal");
        //float _zMov = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump")) 
        { velocity.y = JumpForce; }
        else
        { velocity.y = GetComponent<Rigidbody>().velocity.y;
        }

           

  

        Vector3 _movHorizontal = transform.right * _xMov;
        //Vector3 _movVertical = transform.forward * _zMov;

        Vector3 _velocity = (_movHorizontal).normalized * speed;

        motor.Move(_velocity);

       
        //float _yRot = Input.GetAxisRaw("Mouse X");

        //Vector3 _rotation = new Vector3(0, _yRot, 0) * lookSensitivity;


        //motor.rotate(_rotation);

        //float _xRot = Input.GetAxisRaw("Mouse Y");

        //Vector3 _cameraRotation = new Vector3(_xRot, 0, 0) * lookSensitivity;

        
        //motor.RotateCamera(_cameraRotation);

        GetComponent<Rigidbody>().velocity = velocity;

    }

}