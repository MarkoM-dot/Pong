using System.Collections;
using UnityEngine.Audio;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolumeMusic(float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
    }
    public void SetVolumeSoundFX(float volume)
    {
        audioMixer.SetFloat("SoundFXVolume", volume);
    }
}
