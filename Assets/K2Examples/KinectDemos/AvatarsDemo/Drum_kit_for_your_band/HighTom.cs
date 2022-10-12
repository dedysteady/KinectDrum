using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighTom : MonoBehaviour
{
    public AudioSource _hightTom;

    void Start()
    {
        _hightTom = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _hightTom.Play();
    }
}