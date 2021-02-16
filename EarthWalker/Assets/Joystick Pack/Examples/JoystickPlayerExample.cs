using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    [SerializeField]
    private ForceMode _fMode = ForceMode.VelocityChange;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        rb.AddForce(direction * speed * Time.fixedDeltaTime, _fMode);
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, _fMode);
    }
}