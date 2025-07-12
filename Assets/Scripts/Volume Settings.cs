using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public static VolumeSettings instance;

    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private Toggle musicToggle;
    [SerializeField] private Toggle sfxToggle;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetMusicVolume();
        SetSFXVolume();
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("Music", Mathf.Log10(volume)*20);
    }
    public void SetSFXVolume()
    {
        float volume = sfxSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
    public void MuteMusic()
    {
        if(musicToggle.isOn)
        {
          float volume = musicSlider.minValue;
          myMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
          Debug.Log("Musica 0");
        }
        else
        {
            musicSlider.value = 0.5f;
            float volume = musicSlider.value;
            myMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
            Debug.Log("Musica 0");
        }

    }
    public void MuteSFX()
    {
        if (sfxToggle.isOn)
        {
            float volume = sfxSlider.minValue;
            myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
            Debug.Log("SFX 0");
        }
        else
        {
            sfxSlider.value = 0.5f;
            float volume = sfxSlider.value;
            myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
            Debug.Log("SFX 0");
        }
    }
}
