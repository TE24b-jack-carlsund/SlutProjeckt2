using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    //En array med alla karaktärer
    public GameObject[] characters;

    //hämtar numret som jag sparade i datorns minne
    private string selectedCharacterDataName = "SelectedCharacter";

    //index för den valda karaktären
    int selectedCharacter;

    //referens till spelaren som skapas i scenen
    public GameObject playerObject;
    void Start()
    {
        //hämtar den sparade spelare från playerprefs. 0 används som värde ifall det inte finns något
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);

        //Skapar karaktären 
        playerObject = Instantiate(characters[selectedCharacter]) as GameObject;

        //Positions vecktor som bestämmer var i världen gubben ska spawnas 
        Vector3 spawn = new Vector3(-4, -1, 1);
        playerObject.transform.position = spawn;
    }

    void Update()
    {
        //kollar om användaren klickar escape
        if (Input.GetKey(KeyCode.Escape))
        {
            //Då anropas denna metod som laddar scenen meny
            ReturnToMainMenu();
        }
    }

    public void ReturnToMainMenu()
    {
        //laddar scenen meny
        SceneManager.LoadScene("Menu");
    }
}