using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    //referenser till komponenter och andra script
    private Rigidbody2D rb;
    private LogicScript logic;

    [SerializeField]
    float speed = 2.5f; //fågelns hastighet 
    void Start()
    {
        //hämtar rigidbodyn från objecktet
        rb = GetComponent<Rigidbody2D>();

        //letar upp objecktet och sedan scriptet logicscript
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); 
    }

    //hanterar kollisioner med objeck som har isTriggered aktiverat, annars funkar det inte
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kollar om objecktet som spelaren krockar med har taggen Enemy
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            //anropar metoden i logicscript och drar av health
            logic.Health();
        }
    }
    void FixedUpdate()
    {
        //hämtar inputen från A eller D, gör att du kan gå åt sidorna. 
        float inputX = Input.GetAxisRaw("Horizontal");

        //gör att rigigidbodyn får rörelsen/spelaren kan styra gubben
        rb.linearVelocityX = inputX * speed;
    }
}