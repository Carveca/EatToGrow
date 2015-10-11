using UnityEngine;

public class WinCameraScript : MonoBehaviour
{
    int score = 0;
    
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("GameController").GetComponent<RestartScript>().GetScore();
    }

    void OnGUI()
    {
        GUI.TextField(new Rect(Screen.width / 2 - 50, Screen.height - 50, 100, 30), "Your score: " + score);
    }	
}