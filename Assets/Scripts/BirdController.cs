using UnityEngine;

public class BirdController : MonoBehaviour
{

    
   
    [SerializeField]
    float jumpForce = 2;

    [SerializeField]
    float speed = 2.5f;
    [SerializeField]
    GameObject groundChecker;

    [SerializeField]
    LayerMask groundLayer;

    void Start()
    {
        
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        Vector2 movement = Vector2.right*inputX;

        transform.Translate(movement*speed*Time.deltaTime);
    }
     void FixedUpdate()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundChecker.transform.position, 0.3f, groundLayer);
        if (Input.GetAxisRaw("Jump") > 0 && isGrounded == true)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);




        }
    }
}
