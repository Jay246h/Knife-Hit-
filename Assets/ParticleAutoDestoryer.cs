using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAutoDestoryer : MonoBehaviour
{
    private ParticleSystem particle;

    private void Awake()
    {
        particle = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (particle.isPlaying == false) 
        {
            Destroy(gameObject);
        }
    }
}
