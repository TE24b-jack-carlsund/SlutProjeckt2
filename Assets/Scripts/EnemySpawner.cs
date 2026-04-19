using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public Transform[] enemySpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int randomIndex = Random.Range(0, enemySpawner.Length);
        transform.position = enemySpawner[randomIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
