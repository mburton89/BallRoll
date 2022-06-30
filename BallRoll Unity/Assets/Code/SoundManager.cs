using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource collectSound;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayCollectSound()
    {
        collectSound.Play();
    }
}
