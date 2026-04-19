using UnityEngine;

public class EnemnySpawner : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform[] spawnPoints;
    
    [SerializeField]
    GameObject enemyPrefab;
     float timeBetweenEnemies = 0.5f;
  float timeSinceLastEnemy = 0;
    private GameObject enemy;
    
   
    void Start()
    {
        
       
    }

    void Update()
    {
         
        timeSinceLastEnemy += Time.deltaTime;
    if (timeSinceLastEnemy > timeBetweenEnemies && GameObject.FindGameObjectsWithTag("Enemy").Length < 2)
    {
      int i = Random.Range(0, spawnPoints.Length);
            
            // Skapa fienden på den slumpade platsen
            Instantiate(enemyPrefab, spawnPoints[i].position, Quaternion.identity);
      timeSinceLastEnemy = 0;
    }
    }
    
}
