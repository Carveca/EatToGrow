using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public static MusicScript Instance;

    void Start()
    {
        if (Instance)
            DestroyImmediate(gameObject);
        else
        {
            GameObject.DontDestroyOnLoad(this);
            Instance = this;
        }
    }
}
