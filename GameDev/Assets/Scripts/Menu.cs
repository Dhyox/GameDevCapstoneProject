using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static Menu instance { get; private set; }
    [SerializeField] private AudioMixer mixer;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    private void Start()
    {
        SetVolume("MasterVol");
        SetVolume("BGMVol");
        SetVolume("SFXVol");
    }
    private void SetVolume(string group)
    {
        mixer.SetFloat(group, Mathf.Log10(PlayerPrefs.GetFloat(group, 1)) * 20);
    }

    
}
