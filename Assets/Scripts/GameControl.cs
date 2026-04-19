using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
   public GameObject[] characters;
   public Transform playerStartPosition;
   public string menuScene = "CharacterSelection";
   private string selectedCharacterDataName = "SelectedCharacter";
   int selectedCharacter;
   public GameObject playerObject;
    void Start()
    {
       selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        // playerObject = Instantiate(characters[selectedCharacter], playerStartPosition.position, characters[selectedCharacter].transform.rotation);
        playerObject = Instantiate(characters[selectedCharacter]) as GameObject;
          Vector3 spawn = new Vector3(-4, -1, 1);
           playerObject.transform.position = spawn;
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
