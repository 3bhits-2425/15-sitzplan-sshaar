using UnityEngine;

public class MyScript : MonoBehaviour
{
    [SerializeField] private GameObject Image;
    [SerializeField] private GameObject position;

    void Start()
    {
        for (int i=0; i < 20; i++)
        {
            GameObject obj = Instantiate(Image);
            obj.transform.SetParent(position.transform);

        }
    }
}
