using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ride : MonoBehaviour
{
    public AudioSource _ride;

    void Start()
    {
        _ride = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _ride.Play();
    }
}