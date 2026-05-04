using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip menuMusic;
    public AudioClip backgroundMusic;
    public AudioClip WalkSFX; 
    public AudioClip buttonSFX;
    public AudioClip cauldronBubbleSFX; 
    public AudioClip cauldronDropSFX;
    public AudioClip BFDialogue1;
    public AudioClip WitchDialogue1;
    public AudioClip WitchDialogue2;
    public AudioClip GirlDialogue1;
    public AudioClip GirlDialogue2;
    public AudioClip GirlDialogue3;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Main Menu")
        {
            PlayMusic(menuMusic);
        }
        else
        {
            PlayMusic(backgroundMusic);
        }
    }

    private void PlayMusic(AudioClip clip)
    {
        if (clip == null || musicSource == null) return;

        if (musicSource.clip == clip) return;

        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        if (clip != null && sfxSource != null)
        {
            sfxSource.PlayOneShot(clip);
        }
    }
    public void StartLoopingSFX(AudioClip clip)
    {
        sfxSource.clip = clip;
        sfxSource.loop = true;
        sfxSource.Play();
    }

    public void StopLoopingSFX()
    {
        sfxSource.loop = false;
        sfxSource.Stop();
    }

    public void PlayWalk(bool isWalking)
    {
        if (isWalking && !sfxSource.isPlaying)
        {
            sfxSource.clip = WalkSFX;
            sfxSource.loop = true;
            sfxSource.Play();
        }
        else if (!isWalking && sfxSource.isPlaying)
        {
            sfxSource.Stop();
        }
    }
}
