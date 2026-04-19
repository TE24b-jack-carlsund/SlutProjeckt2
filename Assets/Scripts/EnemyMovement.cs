using UnityEditor.Callbacks;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private LogicScript logic;
    private Rigidbody2D rb;

    float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }   
      
    // Update is called once per frame
    void Update()
    {
          Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
          if (viewPos.x < 0)
        {
            Destroy(gameObject);
            logic.AddScore();
            logic.Health();
        }
    }
    void FixedUpdate()
    {
       rb.linearVelocity = (Vector2.left*speed); 
    }
}
