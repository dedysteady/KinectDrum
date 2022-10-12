using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public AudioSource _crash;

    void Start()
    {
        _crash = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _crash.Play();
    }
}