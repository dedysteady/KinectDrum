using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleTom : MonoBehaviour
{
    public AudioSource _middleTom;

    void Start()
    {
        _middleTom = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _middleTom.Play();
    }
}