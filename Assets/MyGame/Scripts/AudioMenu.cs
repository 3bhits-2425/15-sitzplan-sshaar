using TMPro;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private TMP_Text Name;
    private GameObject playPause;
    public void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        playPause = GameObject.Find("PlayPause");
        if (playPause != null)
        {
            Name = playPause.GetComponentInChildren<TMP_Text>();
        }
        else
        {
            Debug.LogError("nicht gefunden");
        }

    }
    public void Update()
    {
        if (gameObject.name == "playpaus")
        {
            if (myAudioSource.isPlaying)
            {
                Name.SetText("Pause");
            }
            else
            {
                Name.SetText("Play");
            }
        }
    }
    public void PlayAudio()
    {
        FindAnyObjectByType<AudioManager>().Play("piano");
    }

    public void PauseAudio()
    {
        FindAnyObjectByType<AudioManager>().Pause("piano");
    }

    public void PausePlay()
    {

        if (myAudioSource.isPlaying)
        {
            myAudioSource.Pause();
        }
        else
        {
            myAudioSource.Play();
        }
    }
}