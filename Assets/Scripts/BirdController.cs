using UnityEngine;

public class BirdController : MonoBehaviour
{

    [SerializeField]
    float speed = 2.5f;
    void Start()
    {
        
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        Vector2 movement = Vector2.right*inputX;

        transform.Translate(movement*speed*Time.deltaTime);
    }
}
