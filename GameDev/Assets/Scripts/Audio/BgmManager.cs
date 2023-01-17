using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class BgmManager : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnsceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnsceneLoaded;
    }

    private void OnsceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            AudioManager.instance.PlaySound("BGM_Menu", SoundOutput.bgm);
        }
        else
        {
            AudioManager.instance.PlaySound("BGM_Game", SoundOutput.bgm);
        }
    }
}
