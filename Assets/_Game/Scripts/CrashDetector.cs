using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float delayDeadTime;
    [SerializeField] private ParticleSystem crashEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Map"))
        {
            crashEffect.Play();
            Invoke(nameof(ReloadScene), delayDeadTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}