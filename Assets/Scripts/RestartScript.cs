using UnityEngine;

public class RestartScript : MonoBehaviour
{
    void Start()
    {
        GameObject.DontDestroyOnLoad(this);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if(Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel("scene");
        }
    }
}
