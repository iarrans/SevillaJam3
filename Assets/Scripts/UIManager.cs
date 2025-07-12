using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [Header("Paneles")]
    public GameObject mainMenu;
    public GameObject hTP;
    public GameObject credits;
    public GameObject inGame1;
    public GameObject inGame2;
    public GameObject suspects;
    public GameObject proof;
    public GameObject gameOver;
    public GameObject victory;

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
        mainMenu.SetActive(true);
    }
    #region "Paneles"
    public void HowToPlay(bool active)
    {
        if (active){ hTP.SetActive(false); active = !active; }
        else { hTP.SetActive(true); } 
    }
    public void Credits(bool active)
    {
        if (active) { credits.SetActive(false); active = !active; }
        else { credits.SetActive(true); }
    }
    public void InGame1(bool active)
    {
        if (active) { inGame1.SetActive(false); active = !active; }
        else { inGame1.SetActive(true); }
    }
    public void InGame2(bool active)
    {
        if (active) { inGame2.SetActive(false); active = !active; }
        else { inGame2.SetActive(true); }
    }
    public void Suspects(bool active)
    {
        if (active) { suspects.SetActive(false); active = !active; }
        else { suspects.SetActive(true); }
    }
    public void Proof(bool active)
    {
        if (active) { proof.SetActive(false); active = !active; }
        else { proof.SetActive(true); }
    }
    #endregion

    void AcuseSuspect()
    {
        //Este metodo es para acusar al sospechoso en pantalla
    }
}
