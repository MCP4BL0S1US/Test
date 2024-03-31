using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private WheelJoint2D rearWheel;
    [SerializeField] private WheelJoint2D frontWheel;
    JointMotor2D motor; 
    // Start is called before the first frame update
    private void Start()
    {
        motor.maxMotorTorque = 10000;
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            motor.motorSpeed = 1000;
            frontWheel.motor = motor;
            rearWheel.motor = motor;
            rearWheel.useMotor = true;
            frontWheel.useMotor = true;
        }

        else if(Input.GetKey(KeyCode.DownArrow))
        {
            motor.motorSpeed = -1000;
            frontWheel.motor = motor;
            rearWheel.motor = motor;
            rearWheel.useMotor = true;
            frontWheel.useMotor = true;
        }

        else
        {
            rearWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
    }
}
