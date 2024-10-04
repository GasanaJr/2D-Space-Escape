using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    private float thrust = 1000f;
    private float rotate = 100f;
    private AudioSource thrustAudio;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        thrustAudio = GetComponent<AudioSource>();
        thrustAudio.playOnAwake = false;
        thrustAudio.loop = true;
    }
    void Update()
    {
        HandleThrust();
        HandleRotation();
    }

    void HandleThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(thrust * Time.deltaTime * Vector3.up);
            if (!thrustAudio.isPlaying)
            {
                thrustAudio.Play();
            }
        } else
        {
            thrustAudio.Stop();
        }

    }

    void HandleRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotate);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotate);
         }
    }

    private void ApplyRotation(float rotate)
    {
        rb.freezeRotation = true;
        transform.Rotate(rotate * Time.deltaTime * Vector3.forward);
        rb.freezeRotation = false;
    }
}
