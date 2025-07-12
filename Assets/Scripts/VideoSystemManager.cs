using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VideoSystemManager : MonoBehaviour
{
    public static VideoSystemManager Instance;
    public List<GameObject> videoScenes;
    public int currentSceneIndex = 0;
    public GameObject rewindButton;
    public GameObject forwardButton;

    public TextMeshProUGUI videoTitleText;
    public TextMeshProUGUI videoTimeText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void RewindVideo()
    {
        if (currentSceneIndex > 0)
        {
            int newIndex = currentSceneIndex - 1;
            LoadVideoScene(newIndex);
        }
        else
        {
            Debug.Log("Already at the first video scene.");
        }
    }

    public void ForwardVideo()
    {
        if (currentSceneIndex < videoScenes.Count - 1)
        {
            int newIndex = currentSceneIndex + 1;
            LoadVideoScene(newIndex);
        }
        else
        {
            Debug.Log("Already at the last video scene.");
        }
    }

    private void LoadVideoScene(int newSceneIndex)
    {
        videoScenes[currentSceneIndex].SetActive(false);
        currentSceneIndex = newSceneIndex;
        videoScenes[currentSceneIndex].SetActive(true);
        if (currentSceneIndex == 0)
        {
            rewindButton.SetActive(false);
        }
        else if (currentSceneIndex == videoScenes.Count - 1)
        {
            forwardButton.SetActive(false);
        }
        else
        {
            rewindButton.SetActive(true);
            forwardButton.SetActive(true);
        }
        UpdateVideoTitle();
    }

    public void UpdateVideoTitle()
    {
       videoTitleText.text = videoScenes[currentSceneIndex].GetComponent<SceneDetails>().sceneName;
       videoTimeText.text = videoScenes[currentSceneIndex].GetComponent<SceneDetails>().sceneHour;
    }
}
