using UnityEngine;

public class BirdController : MonoBehaviour
{
    private LogicScript logic;
    [SerializeField]
    float speed = 2.5f;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        Vector2 movement = Vector2.right*inputX;
        transform.Translate(movement*speed*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
        logic.Health();
        }
    }
}
