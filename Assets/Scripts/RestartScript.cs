using UnityEngine;

public class RestartScript : MonoBehaviour
{
    public static RestartScript Instance;
    public int m_playerScore;

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

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if(Input.GetKey(KeyCode.Return))
        {
            m_playerScore = 0;
            Application.LoadLevel("scene");
        }
        else if (Input.GetKey(KeyCode.M))
        {
            m_playerScore = 0;
            Application.LoadLevel("menu");
        }
    }

    public void SaveScore(int ammount)
    {
        m_playerScore = ammount;
    }
    public int GetScore()
    {
        return m_playerScore;
    }
}
