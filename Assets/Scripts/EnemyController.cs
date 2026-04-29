using UnityEngine;
public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
            Destroy(this.gameObject);
    }
}
