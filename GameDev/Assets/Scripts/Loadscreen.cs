using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loadscreen : MonoBehaviour
{
    [Header("Click Here!")]
    [SerializeField] private GameObject MainGame;
    [SerializeField] private GameObject LoadingScreen;

    [Header("Slider Loading")] 
    [SerializeField] private Slider Loadgame;

    public void ClickLoad(string sceneIndex)
    {
        MainGame.SetActive(false);
        LoadingScreen.SetActive(true);

        StartCoroutine(LoadAsynchronously(sceneIndex));
    }
    IEnumerator LoadAsynchronously (string sceneIndex)
    {
        AsyncOperation Operation = SceneManager.LoadSceneAsync(sceneIndex);

        while(!Operation.isDone)
        {
            float progressvalue = Mathf.Clamp01(Operation.progress / 0.9f);
            Loadgame.value = progressvalue;
            yield return null;
        }
        
    }
}
