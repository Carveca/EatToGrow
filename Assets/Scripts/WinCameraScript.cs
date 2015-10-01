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
        GUI.TextField(new Rect(Screen.width / 2 - 100, Screen.height - 100, 200, 50), "Your score: " + score);
    }	
}