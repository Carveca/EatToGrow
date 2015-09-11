using UnityEngine;
using System.Collections;

public class SpawnFoodBalls : MonoBehaviour
{
    public Rigidbody2D m_food;
    public float m_respawnTime = 3.0f;
    public float m_foodSpeed = 10.0f;

    float m_xDirection = 1.0f;
    float m_yDirection = -1.0f;
    float m_timer = 0.0f;



    void Update()
    {
        // Update timer
        m_timer += Time.deltaTime;

        // reset timer and spawn food if requirements are met
        if(m_timer >= m_respawnTime)
        {
            m_timer = 0.0f;

            m_xDirection = Random.Range(-1.0f, 1.0f);
            m_yDirection = Random.Range(-1.0f, 1.0f);
            
            Rigidbody2D foodClone;
            foodClone = Instantiate(m_food);
            foodClone.transform.position = this.transform.position;
            foodClone.GetComponent<Rigidbody2D>().AddForce(new Vector2(m_xDirection * m_foodSpeed, m_yDirection * m_foodSpeed));
        }
    }
}
