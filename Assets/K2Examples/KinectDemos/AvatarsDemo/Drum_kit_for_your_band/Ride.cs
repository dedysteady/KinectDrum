using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snare : MonoBehaviour
{
    public AudioSource _snare;

    void Start()
    {
        _snare = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _snare.Play();
    }
}