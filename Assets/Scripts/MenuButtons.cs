using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void ChangeToScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ShowInstructions()
    {

    }

    public void ShowHighScore()
    {

    }

    public void ShowCredits()
    {
        GameObject credits = GameObject.FindGameObjectWithTag("SpriteCredits");
        if (credits.transform.localPosition.y <= -500)
            credits.transform.position += new Vector3(0, 1000, 0);
        else
            credits.transform.position += new Vector3(0, -1000, 0);
    }

    public void BackToDefault()
    {

    }
}
