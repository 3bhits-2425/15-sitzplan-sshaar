using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private Sound[] sounds;

    private AudioManager singleton;
    void Awake()
    {
        if (singleton == null)
        {
            singleton = this;

        }
        else
        {
            Destroy(gameObject);
            return;
        }
        foreach (Sound oneSound in sounds)
        {
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();
            oneSound.audioSource.clip = oneSound.clip;
            oneSound.audioSource.volume= oneSound.volume;
            oneSound.audioSource.pitch = oneSound.pitch;
        }
        for (int i = 0; i < sounds.Length; i++)
        {
            Sound s = sounds[i];
        }
    }

    private Sound findSound (string soundName)
    {
        foreach (Sound oneSound in sounds)
        {
            if (oneSound.name == soundName)
            {
                return oneSound;
            }
        }
        return null;
    }
    public void Play(string soundName)
    {
       findSound(soundName).audioSource.Play();
        
    }
    public void Pause(string soundName)
    {
       findSound(soundName).audioSource.Pause();
    }

}
