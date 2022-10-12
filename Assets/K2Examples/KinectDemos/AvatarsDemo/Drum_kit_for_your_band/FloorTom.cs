using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTom : MonoBehaviour
{
    public AudioSource _floortTom;

    void Start()
    {
        _floortTom = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _floortTom.Play();
    }
}