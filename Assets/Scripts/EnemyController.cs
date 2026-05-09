using UnityEngine;
public class EnemyController : MonoBehaviour
{
    //körs när fiendet krockar med ett annat objeckt som har en collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        //förstör fiende objecktet
        Destroy(this.gameObject);
    }
}