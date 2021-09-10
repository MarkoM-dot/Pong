using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    [SerializeField]
    Slider sliderMusic;
    [SerializeField]
    Slider sliderSoundFX;
    void Start()
    {
        sliderMusic.value = PlayerPrefs.GetFloat("MusicVol", 0.75f);
        sliderSoundFX.value = PlayerPrefs.GetFloat("SoundFXVol", 0.75f);

    }
    public void SetVolumeMusic(float volume)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("MusicVol", volume);
    }
    public void SetVolumeSoundFX(float volume)
    {
        audioMixer.SetFloat("SoundFXVolume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("SoundFXVol", volume);
    }
}
