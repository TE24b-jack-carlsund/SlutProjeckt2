using UnityEngine;
public class EnemyController : MonoBehaviour
{
    [SerializeField]
    GameObject boomPrefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
            // Instantiate(boomPrefab, transform.position, Quaternion.identity); //lånad rad från våran kod
            Destroy(this.gameObject);
    }
}
