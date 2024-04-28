using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusTrail : MonoBehaviour
{
    [SerializeField] private ParticleSystem skiEffect;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Map"))
        {
            skiEffect.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Map"))
        {
            skiEffect.Stop();
        }
    }
}
