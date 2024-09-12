using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clip")]
    public AudioClip background;
    public AudioClip jump;
    void Start()
    {
        musicSource.clip = background;
        musicSource.volume = 0.2f;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip, float volume)
    {
        sfxSource.PlayOneShot(clip, volume);    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
