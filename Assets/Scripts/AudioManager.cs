using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource gameMusic, gameSFX;
   
    [Header("All The Music That Can be used in Music")]
    [SerializeField] private AudioClip[] GameMusic;

    [Header("All The Sound effects That Can be used in Music")]
    [SerializeField] private AudioClip[] GameSFX;

    AudioSource audioSource;

    private void Awake() {
        audioSource = FindObjectOfType<AudioSource>();
    }


}
