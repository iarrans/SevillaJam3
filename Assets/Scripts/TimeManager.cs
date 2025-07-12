using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using Unity.Burst.Intrinsics;
using UnityEngine.Rendering;

public class TimeManager : MonoBehaviour
{

    public TextMeshProUGUI textoTiempo; //texto cuenta atrás

    public bool isPlaying = false; //indica si el temporizador está en marcha o no

    public float minutero = 0;//tiempo total para pasarse el juego
    public int diaFinal = 8; //inicialmente, tiempoTotal

    public float day = 1;


    public static TimeManager Instance; //instancia del temporizador, para poder acceder a él desde otros scripts


    private void Awake()
    {
        Instance = this; //asigna la instancia del temporizador
    }
    public void Start()
    {
        minutero = 0; 
    }

    public void Update()
    {
        if (isPlaying) { 
            minutero += Time.deltaTime; //incrementa el minutero en función del tiempo transcurrido
        }

        if (minutero >= 60)
        {
            minutero = 0; //reinicia el minutero cada minuto
            day += 1; //incrementa el día cada minuto
            textoTiempo.text = day + "-07-91"; //actualiza el texto del día
        }

        if (day == diaFinal) //el juego ha terminado, ha pasado una semana.
        {
            Debug.Log("Game over");
            StartCoroutine(FinNivel());
        }
    }

    public IEnumerator FinNivel()//Prepara los datos para cambiar de nivel
    {
        isPlaying = false; //detiene el temporizador

        yield return new WaitForSeconds(2f); //espera 2 segundos antes de cambiar de escena
        SceneManager.LoadScene("GameOver");
    }

    public void SetPlaying()
    {
        isPlaying = true;
    }
}
