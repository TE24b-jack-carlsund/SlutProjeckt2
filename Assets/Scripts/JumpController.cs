using UnityEngine;

public class JumpController : MonoBehaviour
{
     //hur högt gubben hoppar. 
      public float jumpForce = 9f;

      //refrens till rigidbody objecktet
      private Rigidbody2D rb;

      //variabel isGrounded
      private bool isGrounded;

    void Start()
    {
        //hämtar rigidbody komponenten
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //kollar om knappen space är nedtryckt och om variabel is grounden är true
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            //Den flyttar gubben. Den behåller farten i sidled, men flyttar gubben uppåt. x, y
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    //körs när gubben landar på marken
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //kollar om det är marken genom att kolla om objecktet har taggen Ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            //ändrar isGrounded till true
            isGrounded = true;
        }
    }

    //körs när gubben lämmnar marken
    private void OnollisionExit2D(Collision2D collision)
    {
        //om objecktet har taggen Ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            //isGrounded blir false
            isGrounded = false;
        }
    }
}
