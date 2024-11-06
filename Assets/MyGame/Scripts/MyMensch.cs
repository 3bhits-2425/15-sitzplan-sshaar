using UnityEngine;

public class MyMensch : MonoBehaviour
{
    public Color augenfarbe;
    public string rolleInKlasse;
    public string personName;

    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private GameObject myPrefab;
    void Start()
        
    {
        Debug.Log("Mein Name: " + personName);
        Debug.Log("Meine Augenfarbe: " + augenfarbe);
        Debug.Log("Meine Rolle: " + rolleInKlasse); 

        
        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Leertaste gedruckt");
            myAudioSource.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("leertaste losgelassen");
            myAudioSource.Pause();
        }
    }
}
