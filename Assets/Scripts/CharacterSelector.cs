
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    //Skapar en array med alla karaktärer
    public GameObject[] playerObjects;

    [SerializeField]
    int selectedCharacter = 0; //håller koll på siffran för den valda karaktären

    //hur långt innan den byter till nästa karaktär
    public float switchTime = 1f;

    //används för att skapa en plats i datorns minne där jag senare kommer spara selectedkaraktär indexen
    private string selectedCharacterDataName = "SelectedCharacter"; //används för att skapa en plats i datorns minne där jag senare kommer spara selectedkaraktär indexen

    void Start()
    {
        //startar loopen som växlar mellan karaktärerna
        StartCoroutine(CharacterLoop());

        //gömmer alla karaktärer för att senare visa den valda
        HideAllCharacters();
        playerObjects[selectedCharacter].SetActive(true);
    }

    // Går igenom array och inaktiverar varje gubbe(anropas i void Start)
    private void HideAllCharacters()
    {
        foreach (GameObject c in playerObjects)
        {
            c.SetActive(false);
        }
    }

    //Den här loopen körs och hela tiden och byter mellan karaktärerna
    public IEnumerator CharacterLoop()
    {
        while (true)
        {
            //döljer karaktären som är nu
            playerObjects[selectedCharacter].SetActive(false);

            //Den kommer gå till nästa index, men börja om när index numret blir högre än listan
            selectedCharacter++;
            if (selectedCharacter >= playerObjects.Length)
            {
                selectedCharacter = 0;
            }

            //visar den nya karaktären
            playerObjects[selectedCharacter].SetActive(true);

            //Denna säger att loopen ska vänta innan den körs igen, vilket är viktigt för att man ska hinna se karaktärerna
            yield return new WaitForSeconds(switchTime);
        }
    }

    //Denna körs när du klickar på start knappen
    public void StartGame()
    {
        //Den stoppar loopen så att den inte körs i backgrunden
        StopAllCoroutines();

        //Sparar indexen för den valda karaktären på en plats i datorns minne. Detta gör att den kan användas i "Game" scenen.
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);

        //laddar game senen
        SceneManager.LoadScene("Game");
    }
}