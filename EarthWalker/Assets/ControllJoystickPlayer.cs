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
        //���X�e�B�b�N�ł̉��ړ�
        this.transform.position += this.transform.right * variableJoystick.Horizontal * speed * Time.deltaTime;
        //�E�X�e�B�b�N�ł̉�]
        transform.Rotate(new Vector3(0, speed * variableJoystick.Horizontal, 0));

    }
}