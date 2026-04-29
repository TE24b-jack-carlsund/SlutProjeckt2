using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
   private SceneChanger2 senechanger2;
   
   public int playerScore;
   [SerializeField]
    TMP_Text score;
    public int maxHp = 3;
    public int currentHp = 0;
    [SerializeField]
    Slider hp;

    void Start()
    {
      currentHp = maxHp;
      hp.maxValue = maxHp;
      hp.value = currentHp;
      
    }
     public void AddScore()
   {
      playerScore++;
      score.text = "Score: " + playerScore.ToString();
   }
   public void Health()
   {
       currentHp--;
      hp.value = currentHp;
      if (currentHp == 0)
      {
         SceneManager.LoadScene("End");
      }
   }
}
