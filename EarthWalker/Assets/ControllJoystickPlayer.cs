using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControllJoystickPlayer : MonoBehaviour
{

    public float speed = 1f;
    public float speedR = 1f;
    public VariableJoystick variableJoystick;

    public void FixedUpdate()
    {
        this.transform.position += this.transform.forward * variableJoystick.Vertical * speed * Time.deltaTime;
        //左スティックでの横移動
        this.transform.position += this.transform.right * variableJoystick.Horizontal * speed * Time.deltaTime;
        //右スティックでの回転
        transform.Rotate(new Vector3(0, speed * variableJoystick.Horizontal, 0));

    }
}