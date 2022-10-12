using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiHat : MonoBehaviour
{
    public AudioSource _hiHat;

    void Start()
    {
        _hiHat = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _hiHat.Play();
    }
}