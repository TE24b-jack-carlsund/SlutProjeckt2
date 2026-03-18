using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
   public GameObject[] characters;
   public Transform playerStartPosition;
   public string menuScene = "CharacterSelection";
   private string selectedCharacterDataName = "Fågel1";
   int selectedCharacter;
   public GameObject playerObject;
    void Start()
    {
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        playerObject = Instantiate(characters[selectedCharacter], playerStartPosition.position, characters[selectedCharacter].transform.rotation);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ReturnToMainMenu();
        }
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
