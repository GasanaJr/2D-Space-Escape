using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        HandleThrust();
        HandleRotation();
    }

    void HandleThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Thrust -  Space Clicked");
        }
    }

    void HandleRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Turn Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Turn Right");
        }
    }
}
