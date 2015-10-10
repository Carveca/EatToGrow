using UnityEngine;

public class RestartScript : MonoBehaviour
{
    public int m_playerScore;

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
