using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousParticleOnCollision : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Play the particle effect continuously when the player collides with the collision box
            var emission = particleSystem.emission;
            emission.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Stop the particle effect when the player exits the collision box
            var emission = particleSystem.emission;
            emission.enabled = false;
        }
    }
}
