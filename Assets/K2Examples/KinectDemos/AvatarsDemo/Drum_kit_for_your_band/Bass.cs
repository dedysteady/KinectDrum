using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bass : MonoBehaviour
{
    public AudioSource _bass;

    void Start()
    {
        _bass = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _bass.Play();
    }
}