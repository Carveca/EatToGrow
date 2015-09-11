using UnityEngine;

public class FoodballScript : MonoBehaviour
{
    public float m_lifeTime = 5.0f;
    float m_timer = 0.0f;

    void Update()
    {
        // Update timer
        m_timer += Time.deltaTime;

        // Check expiry
        if(m_timer >= m_lifeTime)
        {
            Destroy(this);
        }
    }
}
