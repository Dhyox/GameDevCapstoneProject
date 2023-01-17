using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionSet : MonoBehaviour
{
    private Menu menuManager;
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider master, bgm, sfx;

    private void Awake()
    {
        bgm.value = PlayerPrefs.GetFloat("BGMVol", 1);
        sfx.value = PlayerPrefs.GetFloat("SFXVol", 1);
    }


    public void SetBGMVol(float value)
    {
        float BGMVolum = Mathf.Log10(value) *20;
        mixer.SetFloat("BGMVol", BGMVolum);
        PlayerPrefs.SetFloat("BGMVol", value);
    }
    public void SetSFXVol(float value)
    {
        float SFXVolum = Mathf.Log10(value) * 20;
        mixer.SetFloat("SFXVol", SFXVolum);
        PlayerPrefs.SetFloat("SFXVol", SFXVolum);
    }
}
