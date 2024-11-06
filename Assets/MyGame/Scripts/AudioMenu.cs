using TMPro;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private TMP_Text Name;
    public void Awake()
    {
        //myAudioSource = GetComponent<AudioSource>();
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
        myAudioSource.Play();
    }

    public void PauseAudio()
    {
        myAudioSource.Pause();
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