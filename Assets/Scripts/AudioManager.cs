using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource gameMusic, gameSFX;
   
    [Header("All The Music That Can be used in Music")]
    [SerializeField] private AudioClip[] gameMusicClips;

    [Header("All The Sound effects That Can be used in Music")]
    [SerializeField] private AudioClip[] gameSFXClips;

    [SerializeField] private Slider musicVolumeSlider, sfxVolumeSlider;


    private void Awake() {
        
    }

    private void Update() {
        MusicVolumeSlider();
        SFXVolumeSlider();
    }
    private void MusicVolumeSlider(){
        musicVolumeSlider.value = gameMusic.volume;
    }

    private void SFXVolumeSlider(){
        sfxVolumeSlider.value = gameSFX.volume;
    }


    public void ToggleSFX(){
        gameSFX.mute = !gameSFX.mute;
    }

    public void ToggleMusic(){
        gameMusic.mute = !gameMusic.mute;
    }
}
