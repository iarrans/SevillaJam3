using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    public AudioClip musicMain;
    public AudioClip musicInGame;
    public AudioClip musicGameOver;
    public AudioClip musicGameWinned;
    public AudioClip Static;
    public AudioClip tvButtons;
    public AudioClip openDrawer;
    public AudioClip closeDrawer;
    public AudioClip papersounds;
    public AudioClip acuse;
    public AudioClip clockAlarm;
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
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = musicMain;
        musicSource.Play();
    }

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
