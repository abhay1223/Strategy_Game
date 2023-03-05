using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AudioManager : MonoBehaviour
{   
    public static AudioManager Instance;
    [SerializeField] private AudioSource gameMusic, gameSFX;
   
    [Header("All The Music That Can be used in Music")]
    [SerializeField] private AudioClip[] gameMusicClips;

    [Header("All The Sound That Can be used in SFX")]
    [SerializeField] private AudioClip[] gameSFXClips;

    [SerializeField] private Slider musicVolumeSlider, sfxVolumeSlider;


    private void Awake() {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }
    }

    private void Start() {
        PlayMusic();
    }

    private void PlayMusic(){
        if(gameMusicClips[0] == null){
            return;
        }else{  
            gameMusic.PlayOneShot(gameMusicClips[0]);
        }

    }

    public void PlaySFX(int i){
        if(gameSFXClips[i] == null){
            Debug.Log("SFX is missing ");
            return;
        }else{
            gameSFX.PlayOneShot(gameSFXClips[i]);
        }
    }
    private void Update() {
        MusicVolumeSlider();
        SFXVolumeSlider();
    }

    public void MusicVolumeSlider(){
       gameMusic.volume =  musicVolumeSlider.value;
    }

    public void SFXVolumeSlider(){
       gameSFX.volume = sfxVolumeSlider.value;
    }


    public void ToggleSFX(){
        gameSFX.PlayOneShot(gameSFXClips[0]);
        gameSFX.mute = !gameSFX.mute;
    }

    public void ToggleMusic(){
        gameSFX.PlayOneShot(gameSFXClips[0]);
        gameMusic.mute = !gameMusic.mute;
    }
}
