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
        } 
        else if (currentSuspectIndex == suspects.Count - 1)
        {
            rightButton.SetActive(false);
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
        UpdateSuspectUI(suspect);
    }

    public void Accuse()
    {
        if (currentSuspect == murderer)
        {
            Debug.Log("Victory");
            //SceneManager.LoadScene("Victory");
        } 
        else
        {
            Debug.Log("Loss");
            //SceneManager.LoadScene("GameOver");
        }
    }
}
