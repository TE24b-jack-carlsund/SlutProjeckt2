using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    private LogicScript logic; //referens till logic scriptet
    [SerializeField]
    float speed = 2.5f;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //den kollar efter komponenten med taggen logic, och sedan letar den efter logicscript
    }
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal"); //känner av om du klickar på piltangenterna a eller d
        Vector2 movement = Vector2.right*inputX; //detta skapar en vecktor som är en riktning beroende på om jag klickar a eller d
        transform.Translate(movement*speed*Time.deltaTime); //gångra hastigheten med vecktorn gånger time.deltatime
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) //Jämför med andra objeckt om de har taggen enemy som spelaren colliderar med. Om de har de körs loopen logic.Health.
        {
        logic.Health();
        }
    }
}
