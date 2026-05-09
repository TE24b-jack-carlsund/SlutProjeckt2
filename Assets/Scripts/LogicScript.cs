using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
   //håller koll på spelarens poäng
   public int playerScore;

   //referens till Ui texten
   [SerializeField]
   TMP_Text score;

   //sätter max antal liv till 3
   public int maxHp = 3;

   //sätter nuvarande hp till 0
   public int currentHp = 0;

   //refrens till Ui slidern som ska vara health baren
   [SerializeField]
   Slider hp;

   void Start()
   {
      //sätter nuvarande hp till 3
      currentHp = maxHp;

      //sätter sliderns max value till 3
      hp.maxValue = maxHp;

      //sätter slidern till 3liv
      hp.value = currentHp;
   }

   //anropas för att öka poängen
   public void AddScore()
   {
      //ökar poäng variabeln med 1
      playerScore++;

      //detta uppdaterar texten
      score.text = "Score: " + playerScore.ToString();
   }

   //health metod som minskar healthen när du kolliderar med ett fiende
   public void Health()
   {
      //minskar med 1
      currentHp--;

      //sätter slidern till nytt hp
      hp.value = currentHp;

      //om hp når 0 så laddas scenen "End"
      if (currentHp == 0)
      {
         SceneManager.LoadScene("End");
      }
   }
}