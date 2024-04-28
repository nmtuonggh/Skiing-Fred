using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delayFinishTime;
    [SerializeField] private ParticleSystem finishEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finishEffect.Play();
            Invoke(nameof(ReloadScene), delayFinishTime);
            
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}