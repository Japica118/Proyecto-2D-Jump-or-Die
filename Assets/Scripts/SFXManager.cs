using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip deathSFX;
    public AudioClip starSFX;
    public AudioClip bombaSFX;

    private AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void DeathSound()
    {
        _audioSource.PlayOneShot(deathSFX);
    }

    public void StarSound()
    {
        _audioSource.PlayOneShot(starSFX);
    }

    public void BombaSound()
    {
        _audioSource.PlayOneShot(bombaSFX);
    }

}
