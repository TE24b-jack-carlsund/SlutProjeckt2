using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] playerObjects;

    [SerializeField]
    int selectedCharacter = 0;

    public float switchTime = 1f;


    
    private string selectedCharacterDataName = "SelectedCharacter";

    // Gömmer alla karaktärer förutom en, sedan kommer den man väljer sparas i selected character
     void Start()
    {
        StartCoroutine(CharacterLoop());
        HideAllCharacters();
        selectedCharacter = PlayerPrefs.GetInt(selectedCharacterDataName, 0);
        playerObjects[selectedCharacter].SetActive(true);
    }
    // Gör att man inte kan se karaktärerna i arrayn.
    private void HideAllCharacters()
    {
        foreach (GameObject g in playerObjects)
        {
            g.SetActive(false);
        }
    }
    // Character loop som loopas så att karaktären i characterselectern byts automatiskt.
    public IEnumerator CharacterLoop()
    {
        while (true)
        {
            playerObjects[selectedCharacter].SetActive(false);
            selectedCharacter++;
            if (selectedCharacter >= playerObjects.Length)
            {
                selectedCharacter = 0;
            }
            playerObjects[selectedCharacter].SetActive(true);
             yield return new WaitForSeconds(switchTime);
        }
    }

    // Gör att gubben spånas in när spelet börjar
    public void StartGame ()
    {
        StopAllCoroutines();
        PlayerPrefs.SetInt(selectedCharacterDataName, selectedCharacter);
        SceneManager.LoadScene("Game");
    }
}

