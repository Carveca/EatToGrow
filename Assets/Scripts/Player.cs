using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    Rigidbody2D body;
    public float lifeTimer;

    int horizontalModifier = 0;
    bool isInAir = true;   

    public int score = 0;
    public int verticalModifier = 6;
    public int move = 5;
    public float startingLife = 60.0f;
    public float eatLife = 1.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        lifeTimer = startingLife;
    }

    void Update()
    {
        // Death check
        if(lifeTimer <= 0.0f || score < 0)
        {
            Application.LoadLevel("Lose");
        }

        lifeTimer -= Time.deltaTime;       

        if(Input.GetKeyDown(KeyCode.R))
        {
            Postpone();
        }
               
        // Vertical movement
        if (Input.GetKeyDown(KeyCode.Space) && isInAir == false)
        {
            body.velocity = new Vector2(body.velocity.x, body.velocity.y + verticalModifier);
            isInAir = true;
        }
    }

    void FixedUpdate()
    {
        // Horizontal movement
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
            horizontalModifier = 0;
        else if (Input.GetKey(KeyCode.A))
            horizontalModifier = -move;
        else if (Input.GetKey(KeyCode.D))
            horizontalModifier = move;
        else
            horizontalModifier = 0;

        body.AddForce(Vector2.right * horizontalModifier);           
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            score++;
            this.transform.localScale += new Vector3(0, 0.01f, 0);
            lifeTimer -= eatLife;
        }           
        else if (collision.gameObject.tag == "Map")
        {
            isInAir = false;
        }           
        else if (collision.gameObject.tag == "Goal")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<RestartScript>().SaveScore(score);
            Application.LoadLevel("win");
        }
    }

    void OnGUI()
    {
        GUILayout.Label("Score: " + score);
    }

    void Postpone()
    {
        score -= 10;
        lifeTimer = startingLife;

        Vector3 scale = this.transform.localScale;
        scale.y = 1;
        this.transform.localScale = scale;
    }
}
