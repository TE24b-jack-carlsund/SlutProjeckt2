using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
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
      if (maxHp == currentHp)
      {
         Debug.Log("Död");
      }
   }
}
