using UnityEngine;

public class EnemnySpawner : MonoBehaviour
{
  //skapar en array med de olika spawnings punkter för fienderna
  public Transform[] spawnPoints;

  //Detta är fiendet som ska skapas 
  [SerializeField]
  GameObject enemyPrefab;

  //Detta är tiden mellan att fienderna spawnas 
  float timeBetweenEnemies = 0.5f;

  //sätter tiden till 0 igen när en fiende spawnats
  float timeSinceLastEnemy = 0;
  void Update()
  {
    //ökar tiden med tiden som gått från förra framen(Obs, denna del är kopierad)
    timeSinceLastEnemy += Time.deltaTime;

    //kollar om det gått tillräckligt med långt tid och om det finns färre än två fiender i scenen
    if (timeSinceLastEnemy > timeBetweenEnemies && GameObject.FindGameObjectsWithTag("Enemy").Length < 2)
    {
      //Denna slumpar en index siffra för att fiendet ska spawnas vid en av platserna i arrayn
      int i = Random.Range(0, spawnPoints.Length);

      // Skapa fienden på den slumpade platsen utan någon rotation
      Instantiate(enemyPrefab, spawnPoints[i].position, Quaternion.identity);

      //Här sätts timern till 0 igen
      timeSinceLastEnemy = 0;
    }
  }

}