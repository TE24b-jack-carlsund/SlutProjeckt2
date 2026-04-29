
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] playerObjects; //lista som innehåller karaktärerna

    [SerializeField]
    int selectedCharacter = 0; //håller koll på siffran för den valda karaktären

    public float switchTime = 1f; //hur långt innan den byter till nästa karaktär


    
    private string selectedCharacterDataName = "SelectedCharacter"; //används för att skapa en plats i datorns minne där jag senare kommer spara selectedkaraktär indexen

    // Gömmer alla karaktärer förutom en, sedan kommer den man väljer sparas i selected character
     void Start()
    {
        StartCoroutine(CharacterLoop()); 
        HideAllCharacters(); 
        playerObjects[selectedCharacter].SetActive(true); 
    }
    // Gör att man inte kan se karaktärerna i arrayn.
    private void HideAllCharacters()
    {
        foreach (GameObject c in playerObjects)
        {
            c.SetActive(false); 
        }
    }
    // Character loop som loopas så att karaktären i characterselectern byts automatiskt.
    public IEnumerator CharacterLoop()
    {
        while (true)
        {
            playerObjects[selectedCharacter].SetActive(false); 
            selectedCharacter++; //går vidare till nästa
            if (selectedCharacter >= playerObjects.Length) 
            {
                selectedCharacter = 0;
            }
            playerObjects[selectedCharacter].SetActive(true); 
             yield return new WaitForSeconds(switchTime); 
        }
    }

    // Gör att gubben spånas in när spelet börjar. När du klickar på knappen
    public void StartGame ()
    {
        StopAllCoroutines(); 
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter); //den sparar heltalet som du selektade karaktären, och när nästa scene laddas så kan den fråga playerprefs vilken gubbe som ska laddas. Första variabeln är namnet där datorn ska göra plats, medan andra variabeln är den som ska sparas på platsen. Det är gubben som den är på som sparas
        SceneManager.LoadScene("Game"); //laddar game senen
    }
}

