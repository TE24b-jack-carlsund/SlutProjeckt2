using UnityEditor.Callbacks;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //referenser till komponenter
    private LogicScript logic;
    private Rigidbody2D rb;

    //Fiendets hastighet/fart
    float speed = 5.0f;

    void Start()
    {
        //hämtar rigidbody komponenten för fysik
        rb = GetComponent<Rigidbody2D>();

        //hittar objecktet Logic och sedan logicscriptet som ligger på den
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        //omvandlar fiendens position i värden till kordinaterna 0 och 1
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        //om deras kordinater är mindre än 0 så har de åkt utanför kanten
        if (viewPos.x < 0)
        {
            //Då förstörs fienderna
            Destroy(gameObject);

            //anropar metoden från logic scriptet som ger spelaren ett poäng
            logic.AddScore();
        }
    }
    void FixedUpdate()
    {
        //Ger fienderna en fart åt vänster
        rb.linearVelocity = (Vector2.left * speed);
    }
}