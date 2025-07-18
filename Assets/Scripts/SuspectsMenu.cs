using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SuspectsMenu : MonoBehaviour
{
    public List<SuspectSO> suspects;
    public SuspectSO murderer;
    public SuspectSO currentSuspect;
    public int currentSuspectIndex = 0;

    public TextMeshProUGUI suspectNameText;
    public TextMeshProUGUI importantPointsText;
    public TextMeshProUGUI testimonyText;
    public Image portraitImage;

    public GameObject leftButton;
    public GameObject rightButton;

    private void Start()
    {
        if (suspects.Count == 0)
        {
            Debug.LogError("No suspects available in the list.");
            return;
        }

        currentSuspect = suspects[currentSuspectIndex];
        UpdateSuspectUI(currentSuspect);
    }

    public void ShowNextSuspect()
    {
        if (currentSuspectIndex == suspects.Count - 1) return;

        currentSuspectIndex = currentSuspectIndex + 1;
        currentSuspect = suspects[currentSuspectIndex];
        UpdateSuspectUI(currentSuspect);
    }

    public void ShowPreviousSuspect()
    {
        if (currentSuspectIndex == 0) return;

        currentSuspectIndex = currentSuspectIndex - 1;
        currentSuspect = suspects[currentSuspectIndex];
        UpdateSuspectUI(currentSuspect);
    }

    private void UpdateSuspectUI(SuspectSO currentSuspect)
    {
        suspectNameText.text = currentSuspect.SuspectName;
        importantPointsText.text = currentSuspect.importantPoints;
        testimonyText.text = currentSuspect.testimony;
        portraitImage.sprite = currentSuspect.portrait;

        if (currentSuspectIndex == 0)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(true);
        } 
        else if (currentSuspectIndex == suspects.Count - 1)
        {
            rightButton.SetActive(false);
            leftButton.SetActive(true);
        } 
        else
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
        }
   
    }

    public void LoadSuspect(SuspectSO suspect)
    {
        currentSuspectIndex = suspects.IndexOf(suspect);
        currentSuspect = suspect;
        UpdateSuspectUI(suspect);
    }

    public void Accuse()
    {
        if (currentSuspect == murderer)
        {
            Debug.Log("Victory");
            StartCoroutine(EndGame(true));
        } 
        else
        {
            Debug.Log("Loss");
            StartCoroutine(EndGame(false));
        }
    }

    public IEnumerator EndGame(bool victory)
    {
        TimeManager.Instance.isPlaying = false; //detiene el temporizador
        yield return new WaitForSeconds(1f); //espera 2 segundos antes de cambiar de escena
        if (victory)
        {
            UIManager.instance.victory.SetActive(true);
            MusicManager.instance.PlayMusic(MusicManager.instance.musicGameWinned);

        }
        else
        {
            UIManager.instance.gameOver.SetActive(true);
            MusicManager.instance.PlayMusic(MusicManager.instance.musicGameOver);

        }

    }

}
